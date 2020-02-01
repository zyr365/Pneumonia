using System;
using System.Drawing;
using System.Text;
using NSoup;
using NSoup.Nodes;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Pneumonia
{
    public partial class Form1 : DevComponents.DotNetBar.OfficeForm
    {
        static string confirmedCount, suspectedCount, deadCount, curedCount, updateTime;
        static string url = "https://3g.dxy.cn/newh5/view/pneumonia";
        static Document doc = NSoupClient.Connect(url).Get();
        public Form1()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();
            WebClient wc = new WebClient();
           byte[] htmlData = wc.DownloadData(url);
           string html = Encoding.UTF8.GetString(htmlData);
           logWrite(html);//将网页内容写入txt文件，以方便查看
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 600000;
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
            //Document doc = NSoupClient.Connect(address).Get();
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
    
}
}
