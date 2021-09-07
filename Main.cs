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
            Process[] processes = null;
            string CurrentProcess = Process.GetCurrentProcess().ProcessName.ToUpper();
            processes = Process.GetProcessesByName(CurrentProcess);
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
                    wc.DownloadFile("http://pgm.bbforest.net/fvs/fvs.msi", Environment.GetEnvironmentVariable("temp") + "\\fvs.msi");
                    Process.Start(new ProcessStartInfo { FileName = Environment.GetEnvironmentVariable("temp") + "\\fvs.msi", UseShellExecute = true });
                    Environment.Exit(0);
                }
                Notice.Text = "업데이트가 있습니다!";
            }

            Notice.Text = $"현재 버전은 v.{ver}입니다.";

            if (Environment.Is64BitOperatingSystem) exe = Application.StartupPath + "x64.exe";
            else exe = Application.StartupPath + "x86.exe";
        }

        public static string file_path, exe;

        private void Run_btn_Click(object sender, EventArgs e)
        {
            if (Path_tbx.Text == "") MessageBox.Show("입력 파일이 비어있습니다.", "Fast Video Spliter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Duration.Text == "00:00:00") MessageBox.Show("재생시간이 0초입니다. 파일을 확인하세요.", "Fast Video Spliter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (radioCustom.Checked) Run_Custom();
            else if (radioSplit.Checked) Run_Split();
            else MessageBox.Show("파일출력 옵션이 지정되지 않았습니다.", "Fast Video Spliter", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Run_Split()
        {
            DialogResult result = MessageBox.Show("입력된 분활 시간에 맞춰 한번에 분활됩니다.\n저사양 컴퓨터에서는 렉이 발생할 수 있습니다.\n계속 하시겠습니까?", "Fast Video Spliter", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;

            string[] dur = Duration.Text.Split(':');
            int dur_sum = Convert.ToInt32(dur[1]); //전체 재생길이(분 대입)
            int target = Convert.ToInt32(Split.Text);

            //시간이 있으면 1시간 단위로 동작
            for (int h_dur= Convert.ToInt32(dur[0]); h_dur > 0; h_dur--)
            {
                dur_sum += 60; //60분 추가
            }

            //기준 시간보다 총 시간이 많으면 동작
            int tar = 0; //분활 시작점
            for (int i = 0; dur_sum > tar; i++) //분활 시작점이 총 길이보다 커질때까지
            {
                int start = Convert.ToInt32(tar) * 60,
                    end = start + Convert.ToInt32(target);
                Process.Start(exe, $"-y -ss {start} -to {end} -i \"{file_path}\" -c copy -map 0 \"{Save_tbx.Text}\\{Save_name.Text} - {i}{dot.Text}\"");
                List($"{tar}분 부터 {tar + target}분 까지 분활하여 저장 : {Save_name.Text} - {i}{dot.Text}");
                tar += target; //분활 길이만큼 분활 시작점 증가
            }
        }

        private void Run_Custom()
        {
            int start = Convert.ToInt32(ms.Text) * 60 + Convert.ToInt32(ss.Text),
                end = Convert.ToInt32(mt.Text) * 60 + Convert.ToInt32(st.Text);
            Process.Start(exe, $"-y -ss {start} -to {end} -i \"{file_path}\" -c copy -map 0 \"{Save_tbx.Text}\\{Save_name.Text}{dot.Text}\"");
            List($"{ms.Text}:{ss.Text}부터 {mt.Text}:{st.Text}까지 저장 : {Save_name.Text}{dot.Text}");
        }

        private void Path_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "동영상을 선택해주세요!";
            if (file.ShowDialog() == DialogResult.OK)
            {
                file_path = file.FileName;
                Path_tbx.Text = file_path;
                dot.Text = Path.GetExtension(file_path);
                Save_name.Text = "[Split]" + Path.GetFileNameWithoutExtension(file_path);
                Engine ffmpeg = new Engine(exe);
                var status = ffmpeg.GetMetaDataAsync(new InputFile(file_path));
                Duration.Text = status.Result.Duration.ToString().Split(".")[0];
                List($"영상선택 : {file_path}");
                List($"영상길이 : {Duration.Text}");

                if (Save_tbx.Text == "") //저장경로가 비어있으면 동일한 폴더로 지정
                {
                    Save_tbx.Text = Path.GetDirectoryName(file_path);
                    List($"저장폴더 : {Save_tbx.Text}");
                }
            }
            
        }
        private void List(string msg)
        {
            this.Invoke(new Action(delegate () {
                listBox1.Items.Add(msg);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1;
            }));
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog save = new CommonOpenFileDialog();
            save.IsFolderPicker = true; //폴더 지정
            save.Title = "자른 동영상을 저장할 폴더";

            //폴더가 정상적으로 선택됐으면 지정
            if (save.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Save_tbx.Text = save.FileName;
                List($"저장폴더 : {Save_tbx.Text}");
            }
        }

        private void ms_Click(object sender, EventArgs e)
        {
            ms.SelectionStart = 0;
            ms.SelectionLength = ms.Text.Length;
            radioCustom.Checked = true;
        }

        private void ss_Click(object sender, EventArgs e)
        {
            ss.SelectionStart = 0;
            ss.SelectionLength = ss.Text.Length;
            radioCustom.Checked = true;
        }

        private void mt_Click(object sender, EventArgs e)
        {
            mt.SelectionStart = 0;
            mt.SelectionLength = mt.Text.Length;
            radioCustom.Checked = true;
        }

        private void st_Click(object sender, EventArgs e)
        {
            st.SelectionStart = 0;
            st.SelectionLength = st.Text.Length;
            radioCustom.Checked = true;
        }

        private void Split_Click(object sender, EventArgs e)
        {
            Split.SelectionStart = 0;
            Split.SelectionLength = Split.Text.Length;
            radioSplit.Checked = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void Save_name_Click(object sender, EventArgs e)
        {
            Save_name.SelectionStart = 0;
            Save_name.SelectionLength = Save_name.Text.Length;
        }
    }
}
