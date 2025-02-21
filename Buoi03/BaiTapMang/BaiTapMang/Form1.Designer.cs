namespace BaiTapMang
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoPhanTu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.btnXoaMang = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phần tử";
            // 
            // txtSoPhanTu
            // 
            this.txtSoPhanTu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhanTu.Location = new System.Drawing.Point(319, 59);
            this.txtSoPhanTu.Name = "txtSoPhanTu";
            this.txtSoPhanTu.Size = new System.Drawing.Size(268, 56);
            this.txtSoPhanTu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá trị";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTri.Location = new System.Drawing.Point(319, 140);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(268, 56);
            this.txtGiaTri.TabIndex = 3;
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiTao.Location = new System.Drawing.Point(650, 38);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(314, 59);
            this.btnKhoiTao.TabIndex = 4;
            this.btnKhoiTao.Text = "Khởi tạo mảng";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // btnXoaMang
            // 
            this.btnXoaMang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMang.Location = new System.Drawing.Point(970, 37);
            this.btnXoaMang.Name = "btnXoaMang";
            this.btnXoaMang.Size = new System.Drawing.Size(296, 60);
            this.btnXoaMang.TabIndex = 5;
            this.btnXoaMang.Text = "Xóa mảng";
            this.btnXoaMang.UseVisualStyleBackColor = true;
            this.btnXoaMang.Click += new System.EventHandler(this.btnXoaMang_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(650, 121);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(139, 68);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(970, 121);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 68);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(56, 347);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(1167, 341);
            this.txtKetQua.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 727);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoaMang);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoPhanTu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BÀI TẬP MẢNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoPhanTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Button btnKhoiTao;
        private System.Windows.Forms.Button btnXoaMang;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

