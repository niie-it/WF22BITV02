namespace DemoCommonControl
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            TxtVanBan = new TextBox();
            BtnDocFile = new Button();
            BtnGhiFile = new Button();
            btnDoiFont = new Button();
            BtnDoiMau = new Button();
            labelDongHo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 41);
            label1.TabIndex = 0;
            label1.Text = "Văn bản";
            // 
            // TxtVanBan
            // 
            TxtVanBan.BackColor = Color.FromArgb(255, 192, 192);
            TxtVanBan.Location = new Point(12, 62);
            TxtVanBan.Multiline = true;
            TxtVanBan.Name = "TxtVanBan";
            TxtVanBan.Size = new Size(776, 320);
            TxtVanBan.TabIndex = 1;
            // 
            // BtnDocFile
            // 
            BtnDocFile.Location = new Point(12, 392);
            BtnDocFile.Name = "BtnDocFile";
            BtnDocFile.Size = new Size(179, 63);
            BtnDocFile.TabIndex = 2;
            BtnDocFile.Text = "Đọc file";
            BtnDocFile.UseVisualStyleBackColor = true;
            BtnDocFile.Click += BtnDocFile_Click;
            // 
            // BtnGhiFile
            // 
            BtnGhiFile.Location = new Point(217, 392);
            BtnGhiFile.Name = "BtnGhiFile";
            BtnGhiFile.Size = new Size(179, 63);
            BtnGhiFile.TabIndex = 2;
            BtnGhiFile.Text = "Ghi file";
            BtnGhiFile.UseVisualStyleBackColor = true;
            BtnGhiFile.Click += BtnGhiFile_Click;
            // 
            // btnDoiFont
            // 
            btnDoiFont.Location = new Point(404, 392);
            btnDoiFont.Name = "btnDoiFont";
            btnDoiFont.Size = new Size(179, 63);
            btnDoiFont.TabIndex = 2;
            btnDoiFont.Text = "Đổi font";
            btnDoiFont.UseVisualStyleBackColor = true;
            btnDoiFont.Click += btnDoiFont_Click;
            // 
            // BtnDoiMau
            // 
            BtnDoiMau.Location = new Point(609, 392);
            BtnDoiMau.Name = "BtnDoiMau";
            BtnDoiMau.Size = new Size(179, 63);
            BtnDoiMau.TabIndex = 2;
            BtnDoiMau.Text = "Đổi màu";
            BtnDoiMau.UseVisualStyleBackColor = true;
            BtnDoiMau.Click += BtnDoiMau_Click;
            // 
            // labelDongHo
            // 
            labelDongHo.AutoSize = true;
            labelDongHo.Location = new Point(404, 9);
            labelDongHo.Name = "labelDongHo";
            labelDongHo.Size = new Size(97, 41);
            labelDongHo.TabIndex = 3;
            labelDongHo.Text = "label2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(labelDongHo);
            Controls.Add(BtnDoiMau);
            Controls.Add(btnDoiFont);
            Controls.Add(BtnGhiFile);
            Controls.Add(BtnDocFile);
            Controls.Add(TxtVanBan);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Demo Common Dialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtVanBan;
        private Button BtnDocFile;
        private Button BtnGhiFile;
        private Button btnDoiFont;
        private Button BtnDoiMau;
        private Label labelDongHo;
        private System.Windows.Forms.Timer timer1;
    }
}
