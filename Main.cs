using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using FFmpeg.NET;
using System.IO;

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

        public static Engine ffmpeg = new Engine(@"C:\ffmpeg\bin\ffmpeg.exe");
        public static string path;

        private void Run_btn_Click(object sender, EventArgs e)
        {
            string option = $"-ss {ms.Text}:{ss.Text} -to {mt.Text}:{st.Text} -i {path} -c copy ";
        }

        private void Path_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "동영상을 선택해주세요!";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                Path_tbx.Text = path;
                dot.Text = Path.GetExtension(path);
                var status = ffmpeg.GetMetaDataAsync(new InputFile(path));
                Duration.Text = status.Result.Duration.ToString();

            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog save = new CommonOpenFileDialog();
            save.IsFolderPicker = true; //폴더 지정
            save.Title = "자른 동영상을 저장할 폴더";
            if (save.ShowDialog() == CommonFileDialogResult.Ok) Save_tbx.Text = save.FileName; //폴더가 정상적으로 선택됐으면 지정
        }
    }
}
