
namespace FastVideoSpliter
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Path_tbx = new System.Windows.Forms.TextBox();
            this.Run_btn = new System.Windows.Forms.Button();
            this.Path_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Notice = new System.Windows.Forms.Label();
            this.Save_tbx = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.dot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.TextBox();
            this.ss = new System.Windows.Forms.TextBox();
            this.mt = new System.Windows.Forms.TextBox();
            this.st = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Split = new System.Windows.Forms.TextBox();
            this.radioSplit = new System.Windows.Forms.RadioButton();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.Save_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Path_tbx
            // 
            this.Path_tbx.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Path_tbx.Location = new System.Drawing.Point(77, 50);
            this.Path_tbx.Name = "Path_tbx";
            this.Path_tbx.ReadOnly = true;
            this.Path_tbx.Size = new System.Drawing.Size(506, 23);
            this.Path_tbx.TabIndex = 0;
            // 
            // Run_btn
            // 
            this.Run_btn.Location = new System.Drawing.Point(679, 9);
            this.Run_btn.Name = "Run_btn";
            this.Run_btn.Size = new System.Drawing.Size(109, 195);
            this.Run_btn.TabIndex = 1;
            this.Run_btn.Text = "분할시작";
            this.Run_btn.UseVisualStyleBackColor = true;
            this.Run_btn.Click += new System.EventHandler(this.Run_btn_Click);
            // 
            // Path_btn
            // 
            this.Path_btn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Path_btn.Location = new System.Drawing.Point(589, 50);
            this.Path_btn.Name = "Path_btn";
            this.Path_btn.Size = new System.Drawing.Size(75, 23);
            this.Path_btn.TabIndex = 1;
            this.Path_btn.Text = "찾아보기";
            this.Path_btn.UseVisualStyleBackColor = true;
            this.Path_btn.Click += new System.EventHandler(this.Path_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "자를파일";
            // 
            // Notice
            // 
            this.Notice.AutoSize = true;
            this.Notice.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Notice.Location = new System.Drawing.Point(12, 9);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(140, 19);
            this.Notice.TabIndex = 3;
            this.Notice.Text = "인터넷 연결 확인중...";
            // 
            // Save_tbx
            // 
            this.Save_tbx.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_tbx.Location = new System.Drawing.Point(77, 115);
            this.Save_tbx.Name = "Save_tbx";
            this.Save_tbx.ReadOnly = true;
            this.Save_tbx.Size = new System.Drawing.Size(506, 23);
            this.Save_tbx.TabIndex = 0;
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_btn.Location = new System.Drawing.Point(589, 115);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 1;
            this.Save_btn.Text = "찾아보기";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "저장폴더";
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Duration.Location = new System.Drawing.Point(166, 45);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(55, 15);
            this.Duration.TabIndex = 3;
            this.Duration.Text = "00:00:00";
            // 
            // dot
            // 
            this.dot.AutoSize = true;
            this.dot.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dot.Location = new System.Drawing.Point(60, 45);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(34, 15);
            this.dot.TabIndex = 4;
            this.dot.Text = ".MXF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "확장자 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(97, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "영상길이 : ";
            // 
            // ms
            // 
            this.ms.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ms.Location = new System.Drawing.Point(350, 45);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(30, 23);
            this.ms.TabIndex = 5;
            this.ms.Text = "0";
            this.ms.Click += new System.EventHandler(this.ms_Click);
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ss.Location = new System.Drawing.Point(398, 45);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(30, 23);
            this.ss.TabIndex = 5;
            this.ss.Text = "0";
            this.ss.Click += new System.EventHandler(this.ss_Click);
            // 
            // mt
            // 
            this.mt.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mt.Location = new System.Drawing.Point(511, 45);
            this.mt.Name = "mt";
            this.mt.Size = new System.Drawing.Size(30, 23);
            this.mt.TabIndex = 5;
            this.mt.Text = "10";
            this.mt.Click += new System.EventHandler(this.mt_Click);
            // 
            // st
            // 
            this.st.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.st.Location = new System.Drawing.Point(558, 45);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(30, 23);
            this.st.TabIndex = 5;
            this.st.Text = "0";
            this.st.Click += new System.EventHandler(this.st_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(294, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "시작지점         분         초";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(454, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "종료지점         분         초";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Duration);
            this.groupBox1.Controls.Add(this.dot);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일입력";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Split);
            this.groupBox2.Controls.Add(this.radioSplit);
            this.groupBox2.Controls.Add(this.radioCustom);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.st);
            this.groupBox2.Controls.Add(this.Save_name);
            this.groupBox2.Controls.Add(this.ms);
            this.groupBox2.Controls.Add(this.mt);
            this.groupBox2.Controls.Add(this.ss);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 108);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "파일출력";
            // 
            // Split
            // 
            this.Split.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Split.Location = new System.Drawing.Point(92, 45);
            this.Split.Name = "Split";
            this.Split.Size = new System.Drawing.Size(30, 23);
            this.Split.TabIndex = 5;
            this.Split.Text = "10";
            this.Split.Click += new System.EventHandler(this.Split_Click);
            // 
            // radioSplit
            // 
            this.radioSplit.AutoSize = true;
            this.radioSplit.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioSplit.Location = new System.Drawing.Point(6, 45);
            this.radioSplit.Name = "radioSplit";
            this.radioSplit.Size = new System.Drawing.Size(85, 19);
            this.radioSplit.TabIndex = 6;
            this.radioSplit.Text = "분단위분할";
            this.radioSplit.UseVisualStyleBackColor = true;
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Checked = true;
            this.radioCustom.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioCustom.Location = new System.Drawing.Point(223, 47);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(73, 19);
            this.radioCustom.TabIndex = 6;
            this.radioCustom.TabStop = true;
            this.radioCustom.Text = "직접입력";
            this.radioCustom.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "저장이름(확장자제외)";
            // 
            // Save_name
            // 
            this.Save_name.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_name.Location = new System.Drawing.Point(135, 75);
            this.Save_name.Name = "Save_name";
            this.Save_name.Size = new System.Drawing.Size(517, 23);
            this.Save_name.TabIndex = 5;
            this.Save_name.Text = "0";
            this.Save_name.Click += new System.EventHandler(this.Save_name_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(92, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "       분 마다 분할";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 211);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 229);
            this.listBox1.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Save_tbx);
            this.Controls.Add(this.Path_tbx);
            this.Controls.Add(this.Notice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Path_btn);
            this.Controls.Add(this.Run_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Fast Video Split By.신광현";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Path_tbx;
        private System.Windows.Forms.Button Run_btn;
        private System.Windows.Forms.Button Path_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Notice;
        private System.Windows.Forms.TextBox Save_tbx;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.Label dot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ms;
        private System.Windows.Forms.TextBox ss;
        private System.Windows.Forms.TextBox mt;
        private System.Windows.Forms.TextBox st;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioSplit;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.TextBox Split;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Save_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
    }
}

