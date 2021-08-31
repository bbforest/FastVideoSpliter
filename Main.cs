using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;

namespace FastVideoSpliter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            //중복실행방지
            System.Diagnostics.Process[] processes = null;
            string CurrentProcess = System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToUpper();
            processes = System.Diagnostics.Process.GetProcessesByName(CurrentProcess);
            if (processes.Length > 1)
            {
                MessageBox.Show("이미 FastVideoSpliter가 실행중입니다.", "Fast Video Spliter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            //업데이트 확인
            WebClient wc = new WebClient();
            string new_ver = wc.DownloadString("http://pgm.bbforest.net/fvs/ver.txt");
            string ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            if (ver != new_ver)
            {
                DialogResult result = MessageBox.Show("업데이트가 있습니다! 업데이트 할까요?", "Fast Video Spliter", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    wc.DownloadFile("http://pgm.bbforest.net/fvs.msi", Environment.GetEnvironmentVariable("temp") + "\\fvs.msi");
                    Process.Start(Environment.GetEnvironmentVariable("temp") + "\\fvs.msi");
                    Environment.Exit(0);
                }
                Notice.Text = "업데이트가 있습니다!";
            }

            Notice.Text = $"현재 버전은 v.{ver}입니다.";
        }

        private void Run_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = FFmpeg.GetMediaInfo(Path_tbx.Text).ToString();
        }

        private void Path_tbx_Click(object sender, EventArgs e)
        {

        }

        private void Path_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "동영상을 선택해주세요!";
            DialogResult result = file.ShowDialog();
            if(result==DialogResult.OK)Path_tbx.Text = file.FileName;
        }
    }
}
