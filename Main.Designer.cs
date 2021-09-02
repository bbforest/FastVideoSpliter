
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
            this.Path_tbx = new System.Windows.Forms.TextBox();
            this.Run_btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.SuspendLayout();
            // 
            // Path_tbx
            // 
            this.Path_tbx.Location = new System.Drawing.Point(78, 31);
            this.Path_tbx.Name = "Path_tbx";
            this.Path_tbx.ReadOnly = true;
            this.Path_tbx.Size = new System.Drawing.Size(506, 23);
            this.Path_tbx.TabIndex = 0;
            // 
            // Run_btn
            // 
            this.Run_btn.Location = new System.Drawing.Point(671, 32);
            this.Run_btn.Name = "Run_btn";
            this.Run_btn.Size = new System.Drawing.Size(104, 91);
            this.Run_btn.TabIndex = 1;
            this.Run_btn.Text = "button1";
            this.Run_btn.UseVisualStyleBackColor = true;
            this.Run_btn.Click += new System.EventHandler(this.Run_btn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 218);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(376, 220);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Path_btn
            // 
            this.Path_btn.Location = new System.Drawing.Point(590, 31);
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
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
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
            this.Save_tbx.Location = new System.Drawing.Point(78, 60);
            this.Save_tbx.Name = "Save_tbx";
            this.Save_tbx.ReadOnly = true;
            this.Save_tbx.Size = new System.Drawing.Size(506, 23);
            this.Save_tbx.TabIndex = 0;
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(590, 60);
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
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "저장폴더";
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Duration.Location = new System.Drawing.Point(197, 90);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(37, 19);
            this.Duration.TabIndex = 3;
            this.Duration.Text = "길이";
            // 
            // dot
            // 
            this.dot.AutoSize = true;
            this.dot.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dot.Location = new System.Drawing.Point(69, 90);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(51, 19);
            this.dot.TabIndex = 4;
            this.dot.Text = "확장자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "확장자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(126, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "영상길이";
            // 
            // ms
            // 
            this.ms.Location = new System.Drawing.Point(12, 113);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(36, 23);
            this.ms.TabIndex = 5;
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(54, 113);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(36, 23);
            this.ss.TabIndex = 5;
            // 
            // mt
            // 
            this.mt.Location = new System.Drawing.Point(116, 113);
            this.mt.Name = "mt";
            this.mt.Size = new System.Drawing.Size(36, 23);
            this.mt.TabIndex = 5;
            // 
            // st
            // 
            this.st.Location = new System.Drawing.Point(158, 113);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(36, 23);
            this.st.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.st);
            this.Controls.Add(this.mt);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.Notice);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Path_btn);
            this.Controls.Add(this.Run_btn);
            this.Controls.Add(this.Save_tbx);
            this.Controls.Add(this.Path_tbx);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Path_tbx;
        private System.Windows.Forms.Button Run_btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
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
    }
}

