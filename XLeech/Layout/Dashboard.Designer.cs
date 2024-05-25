namespace XLeech
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
            label4 = new Label();
            SuspendLayout();
            // 
            // LogSiteTb
            // 
            LogSiteTb.Anchor = AnchorStyles.Left;
            LogSiteTb.BorderStyle = BorderStyle.FixedSingle;
            LogSiteTb.Font = new Font("Calibri Light", 8F, FontStyle.Italic, GraphicsUnit.Point);
            LogSiteTb.Location = new Point(4, 45);
            LogSiteTb.Margin = new Padding(4, 3, 4, 3);
            LogSiteTb.Name = "LogSiteTb";
            LogSiteTb.Size = new Size(701, 376);
            LogSiteTb.TabIndex = 2;
            LogSiteTb.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 3;
            label1.Text = "All Site:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(723, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 4;
            label2.Text = "Post Success:";
            // 
            // AllSiteLb
            // 
            AllSiteLb.AutoSize = true;
            AllSiteLb.Location = new Point(73, 10);
            AllSiteLb.Margin = new Padding(4, 0, 4, 0);
            AllSiteLb.Name = "AllSiteLb";
            AllSiteLb.Size = new Size(22, 25);
            AllSiteLb.TabIndex = 5;
            AllSiteLb.Text = "0";
            // 
            // PostSuccessLb
            // 
            PostSuccessLb.AutoSize = true;
            PostSuccessLb.Location = new Point(834, 10);
            PostSuccessLb.Margin = new Padding(4, 0, 4, 0);
            PostSuccessLb.Name = "PostSuccessLb";
            PostSuccessLb.Size = new Size(22, 25);
            PostSuccessLb.TabIndex = 6;
            PostSuccessLb.Text = "0";
            // 
            // PostFailedLb
            // 
            PostFailedLb.AutoSize = true;
            PostFailedLb.Location = new Point(1004, 10);
            PostFailedLb.Margin = new Padding(4, 0, 4, 0);
            PostFailedLb.Name = "PostFailedLb";
            PostFailedLb.Size = new Size(22, 25);
            PostFailedLb.TabIndex = 8;
            PostFailedLb.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(906, 10);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 7;
            label6.Text = "Post Failed:";
            // 
            // StartBtn
            // 
            StartBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StartBtn.Location = new Point(4, 800);
            StartBtn.Margin = new Padding(4, 5, 4, 5);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(107, 38);
            StartBtn.TabIndex = 9;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // StopBtn
            // 
            StopBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StopBtn.Location = new Point(521, 800);
            StopBtn.Margin = new Padding(4, 5, 4, 5);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(107, 38);
            StopBtn.TabIndex = 10;
            StopBtn.Text = "Stop";
            StopBtn.UseVisualStyleBackColor = true;
            // 
            // ReCrawleBtn
            // 
            ReCrawleBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ReCrawleBtn.Location = new Point(124, 800);
            ReCrawleBtn.Margin = new Padding(4, 5, 4, 5);
            ReCrawleBtn.Name = "ReCrawleBtn";
            ReCrawleBtn.Size = new Size(119, 38);
            ReCrawleBtn.TabIndex = 11;
            ReCrawleBtn.Text = "ReCrawle All";
            ReCrawleBtn.UseVisualStyleBackColor = true;
            ReCrawleBtn.Click += ReCrawleBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 12;
            label3.Text = "Category Done:";
            // 
            // CategoryCrawledLb
            // 
            CategoryCrawledLb.AutoSize = true;
            CategoryCrawledLb.Location = new Point(264, 10);
            CategoryCrawledLb.Margin = new Padding(4, 0, 4, 0);
            CategoryCrawledLb.Name = "CategoryCrawledLb";
            CategoryCrawledLb.Size = new Size(22, 25);
            CategoryCrawledLb.TabIndex = 13;
            CategoryCrawledLb.Text = "0";
            // 
            // LogPostTb
            // 
            LogPostTb.Anchor = AnchorStyles.Right;
            LogPostTb.BorderStyle = BorderStyle.FixedSingle;
            LogPostTb.Font = new Font("Calibri Light", 8F, FontStyle.Italic, GraphicsUnit.Point);
            LogPostTb.Location = new Point(726, 45);
            LogPostTb.Margin = new Padding(4, 3, 4, 3);
            LogPostTb.Name = "LogPostTb";
            LogPostTb.Size = new Size(717, 376);
            LogPostTb.TabIndex = 14;
            LogPostTb.Text = "";
            // 
            // PauseBtn
            // 
            PauseBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PauseBtn.Location = new Point(256, 800);
            PauseBtn.Margin = new Padding(4, 5, 4, 5);
            PauseBtn.Name = "PauseBtn";
            PauseBtn.Size = new Size(119, 38);
            PauseBtn.TabIndex = 15;
            PauseBtn.Text = "Pause";
            PauseBtn.UseVisualStyleBackColor = true;
            // 
            // ResumeBtn
            // 
            ResumeBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ResumeBtn.Location = new Point(393, 800);
            ResumeBtn.Margin = new Padding(4, 5, 4, 5);
            ResumeBtn.Name = "ResumeBtn";
            ResumeBtn.Size = new Size(107, 38);
            ResumeBtn.TabIndex = 16;
            ResumeBtn.Text = "Resume";
            ResumeBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 448);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 17;
            label4.Text = "Configuration";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dashboard";
            Size = new Size(1446, 843);
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
        private Label label4;
    }
}
