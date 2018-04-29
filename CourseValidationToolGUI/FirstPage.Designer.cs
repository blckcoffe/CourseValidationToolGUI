namespace CourseValidationToolGUI
{
    partial class FirstPage
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
            this.ValidateCourseBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.ConsoleLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ValidateCourseBtn
            // 
            this.ValidateCourseBtn.Location = new System.Drawing.Point(24, 64);
            this.ValidateCourseBtn.Name = "ValidateCourseBtn";
            this.ValidateCourseBtn.Size = new System.Drawing.Size(98, 23);
            this.ValidateCourseBtn.TabIndex = 2;
            this.ValidateCourseBtn.Text = "ValidateCourse";
            this.ValidateCourseBtn.UseVisualStyleBackColor = true;
            this.ValidateCourseBtn.Click += new System.EventHandler(this.ValidateCourseBtn_Click);
            // 
            // OpenFolder
            // 
            this.OpenFolder.Location = new System.Drawing.Point(307, 37);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(75, 23);
            this.OpenFolder.TabIndex = 3;
            this.OpenFolder.Text = "OpenFolder";
            this.OpenFolder.UseVisualStyleBackColor = true;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(24, 37);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(283, 21);
            this.folderPath.TabIndex = 4;
            // 
            // ConsoleLog
            // 
            this.ConsoleLog.Location = new System.Drawing.Point(24, 94);
            this.ConsoleLog.Multiline = true;
            this.ConsoleLog.Name = "ConsoleLog";
            this.ConsoleLog.Size = new System.Drawing.Size(358, 312);
            this.ConsoleLog.TabIndex = 5;
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConsoleLog);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.OpenFolder);
            this.Controls.Add(this.ValidateCourseBtn);
            this.Name = "FirstPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ValidateCourseBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button OpenFolder;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.TextBox ConsoleLog;
    }
}

