using System;
using System.Drawing;
using System.Text;
using NSoup;
using NSoup.Nodes;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pneumonia
{
    public partial class MainForm : DevComponents.DotNetBar.OfficeForm
    {
        static string confirmedCount, suspectedCount, deadCount, curedCount, updateTime,dataUpdateTime;
        static string url = "https://3g.dxy.cn/newh5/view/pneumonia";
        static int count = 0;
        static Document doc;
        public MainForm()
        {
            this.EnableGlass = false;
            InitializeComponent();
            this.SizeChanged += new Resize(this).Form1_Resize;  //窗口自适应代码
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();
            WebClient wc = new WebClient();
           byte[] htmlData = wc.DownloadData(url);
           string html = Encoding.UTF8.GetString(htmlData);
           logWrite(html);//将网页内容写入txt文件，以方便查看
           toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            dataUpdateTime = DateTime.Now.ToString();
            count++;
            timer1.Interval = 300000;
            GetData();
            lbl1.Text = "☛ 病毒: " + regularMatchStr("getStatisticsService", "virus\":\"(.+?)\",");
            lbl2.Text = "☛ 传染源: " + regularMatchStr("getStatisticsService", "infectSource\":\"(.+?)\",");
            lbl3.Text = "☛ 传播途径: " + regularMatchStr("getStatisticsService", "passWay\":\"(.+?)\",");
            lbl4.Text ="☛ "+regularMatchStr("getStatisticsService", "remark1\":\"(.+?)\",");
            lbl5.Text ="☛ "+regularMatchStr("getStatisticsService", "remark2\":\"(.+?)\",");
            Image map =UrlToImage("https://img1.dxycdn.com/2020/0201/450/3394153392393266839-135.png");
            pictureBox1.Image = map;
            Image chart = UrlToImage("https://img1.dxycdn.com/2020/0201/693/3394145745204021706-135.png");
            pictureBox2.Image = chart;
            updateTimeLbl.Text = "截至 " + updateTime + " 全国数据统计";
            confirmedLbl.Text = confirmedCount;
            suspectedLbl.Text = suspectedCount;
            deadLbl.Text = deadCount;
            curedLbl.Text = curedCount;
        }

        public static void GetData()
        {
            //直接通过url来获取Document对象
            doc = NSoupClient.Connect(url).Get();
            //先获取id为artContent的元素，再获取所有的p标签
            updateTime = ConvertStringToDateTime(regularMatchStr("getStatisticsService", "modifyTime\":(.+?),")).ToString();
            confirmedCount = regularMatchStr("getStatisticsService", "confirmedCount\":(.+?),");
            suspectedCount = regularMatchStr("getStatisticsService", "suspectedCount\":(.+?),");
            deadCount = regularMatchStr("getStatisticsService", "deadCount\":(.+?),");
            curedCount = regularMatchStr("getStatisticsService", "curedCount\":(.+?),");
        }
        #region 下载图片到Image
        public static Image UrlToImage(string url)
        {
            WebClient mywebclient = new WebClient();
            byte[] Bytes = mywebclient.DownloadData(url);
            using (MemoryStream ms = new MemoryStream(Bytes))
            {
                Image outputImg = Image.FromStream(ms);
                return outputImg;
            }
        }
        #endregion
        public static DateTime ConvertStringToDateTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }
        public static string regularMatchStr(string elementId, string regex)
        {
            Element p = doc.GetElementById(elementId);
            Regex reg = new Regex(regex, RegexOptions.IgnoreCase);
            //例如我想提取line中的NAME值
            Match match = reg.Match(p.Html());
            string value = match.Groups[1].Value;
            return value;
        }
        public static void logWrite(string Message)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\log.txt"))
                File.Create(AppDomain.CurrentDomain.BaseDirectory + "\\log.txt").Close();
            string fileName = AppDomain.CurrentDomain.BaseDirectory + "\\log.txt";
            string content = DateTime.Now.ToLocalTime() + Message + "\r\n";
            StreamWriter sw = new StreamWriter(fileName, true);
            sw.Write(content);
            sw.Close(); sw.Dispose();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//判断鼠标的按键            
            {
                //点击时判断form是否显示,显示就隐藏,隐藏就显示               
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.Hide();
                }
                else if (this.WindowState == FormWindowState.Minimized)
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    this.Activate();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //右键退出事件                
                if (MessageBox.Show("是否需要关闭程序？", "提示:", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)//出错提示                
                {
                    //关闭窗口                    
                    DialogResult = DialogResult.No;
                    Dispose();
                    Close();
                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString() + "  刷新次数 : " + count + "  最新刷新时间 ：" + dataUpdateTime;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //判断是否选择的是最小化按钮
            if (WindowState == FormWindowState.Minimized)
            {
                //隐藏任务栏区图标
                this.ShowInTaskbar = false;
                //图标显示在托盘区
                notifyIcon1.Visible = true;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

    }
}
