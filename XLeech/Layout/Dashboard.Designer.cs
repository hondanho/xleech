﻿namespace XLeech
{
    partial class Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogSiteTb = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            AllSiteLb = new Label();
            PostSuccessLb = new Label();
            PostFailedLb = new Label();
            label6 = new Label();
            StartBtn = new Button();
            StopBtn = new Button();
            ReCrawleBtn = new Button();
            label3 = new Label();
            CategoryCrawledLb = new Label();
            LogPostTb = new RichTextBox();
            PauseBtn = new Button();
            ResumeBtn = new Button();
            SuspendLayout();
            // 
            // LogSiteTb
            // 
            LogSiteTb.Anchor = AnchorStyles.Left;
            LogSiteTb.BorderStyle = BorderStyle.FixedSingle;
            LogSiteTb.Font = new Font("Calibri Light", 8F, FontStyle.Italic, GraphicsUnit.Point);
            LogSiteTb.Location = new Point(3, 36);
            LogSiteTb.Name = "LogSiteTb";
            LogSiteTb.Size = new Size(562, 592);
            LogSiteTb.TabIndex = 2;
            LogSiteTb.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 3;
            label1.Text = "All Site:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 8);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 4;
            label2.Text = "Post Success:";
            // 
            // AllSiteLb
            // 
            AllSiteLb.AutoSize = true;
            AllSiteLb.Location = new Point(58, 8);
            AllSiteLb.Name = "AllSiteLb";
            AllSiteLb.Size = new Size(17, 20);
            AllSiteLb.TabIndex = 5;
            AllSiteLb.Text = "0";
            // 
            // PostSuccessLb
            // 
            PostSuccessLb.AutoSize = true;
            PostSuccessLb.Location = new Point(667, 8);
            PostSuccessLb.Name = "PostSuccessLb";
            PostSuccessLb.Size = new Size(17, 20);
            PostSuccessLb.TabIndex = 6;
            PostSuccessLb.Text = "0";
            // 
            // PostFailedLb
            // 
            PostFailedLb.AutoSize = true;
            PostFailedLb.Location = new Point(803, 8);
            PostFailedLb.Name = "PostFailedLb";
            PostFailedLb.Size = new Size(17, 20);
            PostFailedLb.TabIndex = 8;
            PostFailedLb.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(725, 8);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 7;
            label6.Text = "Post Failed:";
            // 
            // StartBtn
            // 
            StartBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StartBtn.Location = new Point(3, 644);
            StartBtn.Margin = new Padding(3, 4, 3, 4);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(86, 31);
            StartBtn.TabIndex = 9;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // StopBtn
            // 
            StopBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StopBtn.Location = new Point(417, 644);
            StopBtn.Margin = new Padding(3, 4, 3, 4);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(86, 31);
            StopBtn.TabIndex = 10;
            StopBtn.Text = "Stop";
            StopBtn.UseVisualStyleBackColor = true;
            StopBtn.Click += StopBtn_Click;
            // 
            // ReCrawleBtn
            // 
            ReCrawleBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ReCrawleBtn.Location = new Point(99, 644);
            ReCrawleBtn.Margin = new Padding(3, 4, 3, 4);
            ReCrawleBtn.Name = "ReCrawleBtn";
            ReCrawleBtn.Size = new Size(95, 31);
            ReCrawleBtn.TabIndex = 11;
            ReCrawleBtn.Text = "ReCrawle All";
            ReCrawleBtn.UseVisualStyleBackColor = true;
            ReCrawleBtn.Click += ReCrawleBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 8);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 12;
            label3.Text = "Category:";
            // 
            // CategoryCrawledLb
            // 
            CategoryCrawledLb.AutoSize = true;
            CategoryCrawledLb.Location = new Point(181, 8);
            CategoryCrawledLb.Name = "CategoryCrawledLb";
            CategoryCrawledLb.Size = new Size(17, 20);
            CategoryCrawledLb.TabIndex = 13;
            CategoryCrawledLb.Text = "0";
            // 
            // LogPostTb
            // 
            LogPostTb.Anchor = AnchorStyles.Right;
            LogPostTb.BorderStyle = BorderStyle.FixedSingle;
            LogPostTb.Font = new Font("Calibri Light", 8F, FontStyle.Italic, GraphicsUnit.Point);
            LogPostTb.Location = new Point(581, 36);
            LogPostTb.Name = "LogPostTb";
            LogPostTb.Size = new Size(574, 592);
            LogPostTb.TabIndex = 14;
            LogPostTb.Text = "";
            // 
            // PauseBtn
            // 
            PauseBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PauseBtn.Location = new Point(205, 644);
            PauseBtn.Margin = new Padding(3, 4, 3, 4);
            PauseBtn.Name = "PauseBtn";
            PauseBtn.Size = new Size(95, 31);
            PauseBtn.TabIndex = 15;
            PauseBtn.Text = "Pause";
            PauseBtn.UseVisualStyleBackColor = true;
            PauseBtn.Click += PauseBtn_Click;
            // 
            // ResumeBtn
            // 
            ResumeBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ResumeBtn.Location = new Point(314, 644);
            ResumeBtn.Margin = new Padding(3, 4, 3, 4);
            ResumeBtn.Name = "ResumeBtn";
            ResumeBtn.Size = new Size(86, 31);
            ResumeBtn.TabIndex = 16;
            ResumeBtn.Text = "Resume";
            ResumeBtn.UseVisualStyleBackColor = true;
            ResumeBtn.Click += ResumeBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ResumeBtn);
            Controls.Add(PauseBtn);
            Controls.Add(LogPostTb);
            Controls.Add(CategoryCrawledLb);
            Controls.Add(label3);
            Controls.Add(ReCrawleBtn);
            Controls.Add(StopBtn);
            Controls.Add(StartBtn);
            Controls.Add(PostFailedLb);
            Controls.Add(label6);
            Controls.Add(PostSuccessLb);
            Controls.Add(AllSiteLb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LogSiteTb);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Size = new Size(1157, 675);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox LogSiteTb;
        private Label label1;
        private Label label2;
        private Label AllSiteLb;
        private Label PostSuccessLb;
        private Label PostFailedLb;
        private Label label6;
        private Button StartBtn;
        private Button StopBtn;
        private Button ReCrawleBtn;
        private Label label3;
        private Label CategoryCrawledLb;
        private RichTextBox LogPostTb;
        private Button PauseBtn;
        private Button ResumeBtn;
    }
}
