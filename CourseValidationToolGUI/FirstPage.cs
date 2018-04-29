using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;


namespace CourseValidationToolGUI
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void ValidateCourseBtn_Click(object sender, EventArgs e)
        {
            if ( folderPath.Text == "")
            {
                return;
            }

            CourseValidator courseValidator = new CourseValidator(folderPath.Text);
            bool rslt = courseValidator.Execute();
            if ( rslt )
            {
                MessageBox.Show("校验完成", "提示",MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("校验失败", "提示", MessageBoxButtons.OKCancel);
            }

            FileStream fs = new FileStream("E:\\workspace\\CourseValidationTool\\CourseValidationToolDll\\CourseValidationToolDll\\checklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin); string str = sr.ReadToEnd(); this.ConsoleLog.Text = str;
            sr.Close();
            fs.Close();
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            folderPath.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
