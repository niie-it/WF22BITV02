namespace NamThangRucRo
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
            label1 = new Label();
            label2 = new Label();
            txtNam = new TextBox();
            txtThang = new TextBox();
            btnKiemTra = new Button();
            txtKetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 72);
            label1.Name = "label1";
            label1.Size = new Size(81, 41);
            label1.TabIndex = 0;
            label1.Text = "Năm";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 160);
            label2.Name = "label2";
            label2.Size = new Size(101, 41);
            label2.TabIndex = 1;
            label2.Text = "Tháng";
            label2.Click += label2_Click;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(252, 72);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(250, 47);
            txtNam.TabIndex = 2;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(253, 166);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(250, 47);
            txtThang.TabIndex = 3;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(253, 252);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(250, 58);
            btnKiemTra.TabIndex = 4;
            btnKiemTra.Text = "Kiểm tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(57, 347);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(682, 118);
            txtKetQua.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(txtKetQua);
            Controls.Add(btnKiemTra);
            Controls.Add(txtThang);
            Controls.Add(txtNam);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Kiểm tra năm, tháng";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNam;
        private TextBox txtThang;
        private Button btnKiemTra;
        private TextBox txtKetQua;
    }
}
