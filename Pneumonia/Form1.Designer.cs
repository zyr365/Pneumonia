﻿namespace Pneumonia
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.updateTimeLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmedLbl = new System.Windows.Forms.Label();
            this.suspectedLbl = new System.Windows.Forms.Label();
            this.deadLbl = new System.Windows.Forms.Label();
            this.curedLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 289);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(381, 289);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(481, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // updateTimeLbl
            // 
            this.updateTimeLbl.AutoSize = true;
            this.updateTimeLbl.Location = new System.Drawing.Point(25, 24);
            this.updateTimeLbl.Name = "updateTimeLbl";
            this.updateTimeLbl.Size = new System.Drawing.Size(341, 19);
            this.updateTimeLbl.TabIndex = 3;
            this.updateTimeLbl.Text = "截至 2020-02-01 11:16 全国数据统计";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "确诊病例";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "疑似病例";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "死亡人数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "治愈人数";
            // 
            // confirmedLbl
            // 
            this.confirmedLbl.AutoSize = true;
            this.confirmedLbl.ForeColor = System.Drawing.Color.Red;
            this.confirmedLbl.Location = new System.Drawing.Point(84, 70);
            this.confirmedLbl.Name = "confirmedLbl";
            this.confirmedLbl.Size = new System.Drawing.Size(59, 19);
            this.confirmedLbl.TabIndex = 8;
            this.confirmedLbl.Text = "11821";
            // 
            // suspectedLbl
            // 
            this.suspectedLbl.AutoSize = true;
            this.suspectedLbl.ForeColor = System.Drawing.Color.Orange;
            this.suspectedLbl.Location = new System.Drawing.Point(291, 70);
            this.suspectedLbl.Name = "suspectedLbl";
            this.suspectedLbl.Size = new System.Drawing.Size(59, 19);
            this.suspectedLbl.TabIndex = 9;
            this.suspectedLbl.Text = "17988";
            // 
            // deadLbl
            // 
            this.deadLbl.AutoSize = true;
            this.deadLbl.ForeColor = System.Drawing.Color.DimGray;
            this.deadLbl.Location = new System.Drawing.Point(509, 70);
            this.deadLbl.Name = "deadLbl";
            this.deadLbl.Size = new System.Drawing.Size(39, 19);
            this.deadLbl.TabIndex = 10;
            this.deadLbl.Text = "259";
            // 
            // curedLbl
            // 
            this.curedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curedLbl.AutoSize = true;
            this.curedLbl.ForeColor = System.Drawing.Color.Green;
            this.curedLbl.Location = new System.Drawing.Point(723, 70);
            this.curedLbl.Name = "curedLbl";
            this.curedLbl.Size = new System.Drawing.Size(39, 19);
            this.curedLbl.TabIndex = 11;
            this.curedLbl.Text = "245";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(30, 130);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(293, 19);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "☛ 病毒:新型冠状病毒 2019-nCoV";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(30, 159);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(355, 19);
            this.lbl2.TabIndex = 13;
            this.lbl2.Text = "☛ 传染源: 野生动物，可能为中华菊头蝠";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(30, 190);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(450, 19);
            this.lbl3.TabIndex = 14;
            this.lbl3.Text = "☛ 传播途径: 经呼吸道飞沫传播，亦可通过接触传播";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(30, 220);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(792, 19);
            this.lbl4.TabIndex = 15;
            this.lbl4.Text = "☛ 易感人群: 人群普遍易感。老年人及有基础疾病者感染后病情较重，儿童及婴幼儿也有发病";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(30, 248);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(597, 19);
            this.lbl5.TabIndex = 16;
            this.lbl5.Text = "☛ 潜伏期: 一般为 3~7 天，最长不超过 14 天，潜伏期内存在传染性";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 696);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.curedLbl);
            this.Controls.Add(this.deadLbl);
            this.Controls.Add(this.suspectedLbl);
            this.Controls.Add(this.confirmedLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateTimeLbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "全国疫情实时图";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label updateTimeLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label confirmedLbl;
        private System.Windows.Forms.Label suspectedLbl;
        private System.Windows.Forms.Label deadLbl;
        private System.Windows.Forms.Label curedLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
    }
}

