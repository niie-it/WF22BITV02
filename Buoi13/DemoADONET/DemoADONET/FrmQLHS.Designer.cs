namespace DemoADONET
{
    partial class FrmQLHS
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
            CboLop = new ComboBox();
            DgvHocSinh = new DataGridView();
            label2 = new Label();
            TxtMaHS = new TextBox();
            label3 = new Label();
            TxtHoTen = new TextBox();
            DtpNgaySinh = new DateTimePicker();
            TxtDiemTB = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtDiaChi = new TextBox();
            BtnThem = new Button();
            BtnSua = new Button();
            BtnXoa = new Button();
            BtnTim = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvHocSinh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 90);
            label1.Name = "label1";
            label1.Size = new Size(85, 48);
            label1.TabIndex = 0;
            label1.Text = "Lớp";
            // 
            // CboLop
            // 
            CboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            CboLop.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CboLop.FormattingEnabled = true;
            CboLop.Location = new Point(242, 90);
            CboLop.Margin = new Padding(3, 4, 3, 4);
            CboLop.Name = "CboLop";
            CboLop.Size = new Size(391, 56);
            CboLop.TabIndex = 1;
            CboLop.SelectedIndexChanged += CboLop_SelectedIndexChanged;
            // 
            // DgvHocSinh
            // 
            DgvHocSinh.AllowUserToAddRows = false;
            DgvHocSinh.AllowUserToDeleteRows = false;
            DgvHocSinh.AllowUserToOrderColumns = true;
            DgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvHocSinh.Location = new Point(37, 559);
            DgvHocSinh.Margin = new Padding(3, 4, 3, 4);
            DgvHocSinh.Name = "DgvHocSinh";
            DgvHocSinh.ReadOnly = true;
            DgvHocSinh.RowHeadersWidth = 102;
            DgvHocSinh.RowTemplate.Height = 40;
            DgvHocSinh.Size = new Size(2040, 851);
            DgvHocSinh.TabIndex = 2;
            DgvHocSinh.CellContentClick += DgvHocSinh_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 183);
            label2.Name = "label2";
            label2.Size = new Size(134, 48);
            label2.TabIndex = 3;
            label2.Text = "Mã HS";
            // 
            // TxtMaHS
            // 
            TxtMaHS.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMaHS.Location = new Point(242, 183);
            TxtMaHS.Margin = new Padding(3, 4, 3, 4);
            TxtMaHS.Name = "TxtMaHS";
            TxtMaHS.Size = new Size(391, 56);
            TxtMaHS.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 306);
            label3.Name = "label3";
            label3.Size = new Size(138, 48);
            label3.TabIndex = 5;
            label3.Text = "Họ tên";
            // 
            // TxtHoTen
            // 
            TxtHoTen.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtHoTen.Location = new Point(242, 298);
            TxtHoTen.Margin = new Padding(3, 4, 3, 4);
            TxtHoTen.Name = "TxtHoTen";
            TxtHoTen.Size = new Size(1306, 56);
            TxtHoTen.TabIndex = 6;
            // 
            // DtpNgaySinh
            // 
            DtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            DtpNgaySinh.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpNgaySinh.Format = DateTimePickerFormat.Custom;
            DtpNgaySinh.Location = new Point(1172, 74);
            DtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
            DtpNgaySinh.Name = "DtpNgaySinh";
            DtpNgaySinh.Size = new Size(376, 56);
            DtpNgaySinh.TabIndex = 7;
            // 
            // TxtDiemTB
            // 
            TxtDiemTB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDiemTB.Location = new Point(1172, 183);
            TxtDiemTB.Margin = new Padding(3, 4, 3, 4);
            TxtDiemTB.Name = "TxtDiemTB";
            TxtDiemTB.Size = new Size(376, 56);
            TxtDiemTB.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 411);
            label4.Name = "label4";
            label4.Size = new Size(140, 48);
            label4.TabIndex = 9;
            label4.Text = "Đại chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(854, 74);
            label5.Name = "label5";
            label5.Size = new Size(194, 48);
            label5.TabIndex = 9;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(854, 183);
            label6.Name = "label6";
            label6.Size = new Size(172, 48);
            label6.TabIndex = 9;
            label6.Text = "Điểm TB";
            // 
            // TxtDiaChi
            // 
            TxtDiaChi.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDiaChi.Location = new Point(242, 411);
            TxtDiaChi.Margin = new Padding(3, 4, 3, 4);
            TxtDiaChi.Name = "TxtDiaChi";
            TxtDiaChi.Size = new Size(1306, 56);
            TxtDiaChi.TabIndex = 10;
            // 
            // BtnThem
            // 
            BtnThem.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnThem.Location = new Point(1599, 57);
            BtnThem.Margin = new Padding(3, 4, 3, 4);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(220, 159);
            BtnThem.TabIndex = 11;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = true;
            BtnThem.Click += BtnThem_Click;
            // 
            // BtnSua
            // 
            BtnSua.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSua.Location = new Point(1850, 57);
            BtnSua.Margin = new Padding(3, 4, 3, 4);
            BtnSua.Name = "BtnSua";
            BtnSua.Size = new Size(220, 159);
            BtnSua.TabIndex = 11;
            BtnSua.Text = "Sửa";
            BtnSua.UseVisualStyleBackColor = true;
            BtnSua.Click += BtnSua_Click;
            // 
            // BtnXoa
            // 
            BtnXoa.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnXoa.Location = new Point(1850, 263);
            BtnXoa.Margin = new Padding(3, 4, 3, 4);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(220, 159);
            BtnXoa.TabIndex = 11;
            BtnXoa.Text = "Xóa";
            BtnXoa.UseVisualStyleBackColor = true;
            BtnXoa.Click += BtnXoa_Click;
            // 
            // BtnTim
            // 
            BtnTim.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnTim.Location = new Point(1608, 263);
            BtnTim.Margin = new Padding(3, 4, 3, 4);
            BtnTim.Name = "BtnTim";
            BtnTim.Size = new Size(220, 159);
            BtnTim.TabIndex = 11;
            BtnTim.Text = "Tìm";
            BtnTim.UseVisualStyleBackColor = true;
            // 
            // FrmQLHS
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2130, 1450);
            Controls.Add(BtnTim);
            Controls.Add(BtnXoa);
            Controls.Add(BtnSua);
            Controls.Add(BtnThem);
            Controls.Add(TxtDiaChi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtDiemTB);
            Controls.Add(DtpNgaySinh);
            Controls.Add(TxtHoTen);
            Controls.Add(label3);
            Controls.Add(TxtMaHS);
            Controls.Add(label2);
            Controls.Add(DgvHocSinh);
            Controls.Add(CboLop);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmQLHS";
            Text = "QUẢN LÝ HỌC SINH";
            Load += FrmQLHS_Load;
            ((System.ComponentModel.ISupportInitialize)DgvHocSinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboLop;
        private System.Windows.Forms.DataGridView DgvHocSinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMaHS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtHoTen;
        private System.Windows.Forms.DateTimePicker DtpNgaySinh;
        private System.Windows.Forms.TextBox TxtDiemTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDiaChi;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnTim;
    }
}
