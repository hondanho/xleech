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
            this.LogSiteTb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AllSiteLb = new System.Windows.Forms.Label();
            this.PostSuccessLb = new System.Windows.Forms.Label();
            this.PostFailedLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.ReCrawleBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryCrawledLb = new System.Windows.Forms.Label();
            this.LogPostTb = new System.Windows.Forms.RichTextBox();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogSiteTb
            // 
            this.LogSiteTb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LogSiteTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogSiteTb.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LogSiteTb.Location = new System.Drawing.Point(3, 27);
            this.LogSiteTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogSiteTb.Name = "LogSiteTb";
            this.LogSiteTb.Size = new System.Drawing.Size(492, 227);
            this.LogSiteTb.TabIndex = 2;
            this.LogSiteTb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Site:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Post Success:";
            // 
            // AllSiteLb
            // 
            this.AllSiteLb.AutoSize = true;
            this.AllSiteLb.Location = new System.Drawing.Point(51, 6);
            this.AllSiteLb.Name = "AllSiteLb";
            this.AllSiteLb.Size = new System.Drawing.Size(13, 15);
            this.AllSiteLb.TabIndex = 5;
            this.AllSiteLb.Text = "0";
            // 
            // PostSuccessLb
            // 
            this.PostSuccessLb.AutoSize = true;
            this.PostSuccessLb.Location = new System.Drawing.Point(584, 6);
            this.PostSuccessLb.Name = "PostSuccessLb";
            this.PostSuccessLb.Size = new System.Drawing.Size(13, 15);
            this.PostSuccessLb.TabIndex = 6;
            this.PostSuccessLb.Text = "0";
            // 
            // PostFailedLb
            // 
            this.PostFailedLb.AutoSize = true;
            this.PostFailedLb.Location = new System.Drawing.Point(703, 6);
            this.PostFailedLb.Name = "PostFailedLb";
            this.PostFailedLb.Size = new System.Drawing.Size(13, 15);
            this.PostFailedLb.TabIndex = 8;
            this.PostFailedLb.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Post Failed:";
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartBtn.Location = new System.Drawing.Point(3, 483);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 9;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopBtn.Location = new System.Drawing.Point(365, 483);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 10;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // ReCrawleBtn
            // 
            this.ReCrawleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReCrawleBtn.Location = new System.Drawing.Point(87, 483);
            this.ReCrawleBtn.Name = "ReCrawleBtn";
            this.ReCrawleBtn.Size = new System.Drawing.Size(83, 23);
            this.ReCrawleBtn.TabIndex = 11;
            this.ReCrawleBtn.Text = "ReCrawle All";
            this.ReCrawleBtn.UseVisualStyleBackColor = true;
            this.ReCrawleBtn.Click += new System.EventHandler(this.ReCrawleBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Category Done:";
            // 
            // CategoryCrawledLb
            // 
            this.CategoryCrawledLb.AutoSize = true;
            this.CategoryCrawledLb.Location = new System.Drawing.Point(185, 6);
            this.CategoryCrawledLb.Name = "CategoryCrawledLb";
            this.CategoryCrawledLb.Size = new System.Drawing.Size(13, 15);
            this.CategoryCrawledLb.TabIndex = 13;
            this.CategoryCrawledLb.Text = "0";
            // 
            // LogPostTb
            // 
            this.LogPostTb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LogPostTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogPostTb.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LogPostTb.Location = new System.Drawing.Point(508, 27);
            this.LogPostTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogPostTb.Name = "LogPostTb";
            this.LogPostTb.Size = new System.Drawing.Size(503, 445);
            this.LogPostTb.TabIndex = 14;
            this.LogPostTb.Text = "";
            // 
            // PauseBtn
            // 
            this.PauseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PauseBtn.Location = new System.Drawing.Point(179, 483);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(83, 23);
            this.PauseBtn.TabIndex = 15;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResumeBtn.Location = new System.Drawing.Point(275, 483);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(75, 23);
            this.ResumeBtn.TabIndex = 16;
            this.ResumeBtn.Text = "Resume";
            this.ResumeBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Configuration";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResumeBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.LogPostTb);
            this.Controls.Add(this.CategoryCrawledLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReCrawleBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.PostFailedLb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PostSuccessLb);
            this.Controls.Add(this.AllSiteLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogSiteTb);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1012, 506);
            this.ResumeLayout(false);
            this.PerformLayout();

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
