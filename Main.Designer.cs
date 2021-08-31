
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
            this.SuspendLayout();
            // 
            // Path_tbx
            // 
            this.Path_tbx.Location = new System.Drawing.Point(78, 31);
            this.Path_tbx.Name = "Path_tbx";
            this.Path_tbx.ReadOnly = true;
            this.Path_tbx.Size = new System.Drawing.Size(506, 23);
            this.Path_tbx.TabIndex = 0;
            this.Path_tbx.Click += new System.EventHandler(this.Path_tbx_Click);
            // 
            // Run_btn
            // 
            this.Run_btn.Location = new System.Drawing.Point(713, 130);
            this.Run_btn.Name = "Run_btn";
            this.Run_btn.Size = new System.Drawing.Size(75, 23);
            this.Run_btn.TabIndex = 1;
            this.Run_btn.Text = "button1";
            this.Run_btn.UseVisualStyleBackColor = true;
            this.Run_btn.Click += new System.EventHandler(this.Run_btn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(78, 176);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Notice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Path_btn);
            this.Controls.Add(this.Run_btn);
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
    }
}

