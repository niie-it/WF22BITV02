namespace Lab02BT04_TruyenDuLieu
{
    partial class FrmNhapLieu
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
            txtSoDong = new TextBox();
            txtSoCot = new TextBox();
            btnKhoiTao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(55, 44);
            label1.Name = "label1";
            label1.Size = new Size(165, 48);
            label1.TabIndex = 0;
            label1.Text = "Số dòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(65, 134);
            label2.Name = "label2";
            label2.Size = new Size(130, 48);
            label2.TabIndex = 1;
            label2.Text = "Số cột";
            // 
            // txtSoDong
            // 
            txtSoDong.Font = new Font("Tahoma", 12F);
            txtSoDong.Location = new Point(246, 36);
            txtSoDong.Name = "txtSoDong";
            txtSoDong.Size = new Size(250, 56);
            txtSoDong.TabIndex = 2;
            // 
            // txtSoCot
            // 
            txtSoCot.Font = new Font("Tahoma", 12F);
            txtSoCot.Location = new Point(246, 126);
            txtSoCot.Name = "txtSoCot";
            txtSoCot.Size = new Size(250, 56);
            txtSoCot.TabIndex = 3;
            // 
            // btnKhoiTao
            // 
            btnKhoiTao.Font = new Font("Tahoma", 12F);
            btnKhoiTao.Location = new Point(548, 46);
            btnKhoiTao.Name = "btnKhoiTao";
            btnKhoiTao.Size = new Size(202, 112);
            btnKhoiTao.TabIndex = 4;
            btnKhoiTao.Text = "Khởi tạo";
            btnKhoiTao.UseVisualStyleBackColor = true;
            btnKhoiTao.Click += btnKhoiTao_Click;
            // 
            // FrmNhapLieu
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 220);
            Controls.Add(btnKhoiTao);
            Controls.Add(txtSoCot);
            Controls.Add(txtSoDong);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNhapLieu";
            Text = "NHẬP LIỆU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSoDong;
        private TextBox txtSoCot;
        private Button btnKhoiTao;
    }
}
