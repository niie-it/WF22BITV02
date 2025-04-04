namespace DemoEFCore
{
    partial class FrmMain
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
            CboKhachHang = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            CboNhanVien = new ComboBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(655, 55);
            label1.Name = "label1";
            label1.Size = new Size(475, 89);
            label1.TabIndex = 0;
            label1.Text = "LẬP HÓA ĐƠN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.9000006F);
            label2.Location = new Point(23, 182);
            label2.Name = "label2";
            label2.Size = new Size(311, 72);
            label2.TabIndex = 1;
            label2.Text = "Khách hàng";
            // 
            // CboKhachHang
            // 
            CboKhachHang.Font = new Font("Segoe UI", 15.9000006F);
            CboKhachHang.FormattingEnabled = true;
            CboKhachHang.Location = new Point(410, 179);
            CboKhachHang.Name = "CboKhachHang";
            CboKhachHang.Size = new Size(827, 79);
            CboKhachHang.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.9000006F);
            button1.Location = new Point(1263, 182);
            button1.Name = "button1";
            button1.Size = new Size(372, 83);
            button1.TabIndex = 3;
            button1.Text = "Tạo mới KH";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.9000006F);
            label3.Location = new Point(23, 315);
            label3.Name = "label3";
            label3.Size = new Size(389, 72);
            label3.TabIndex = 4;
            label3.Text = "Sản phẩm mua";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 420);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(1612, 375);
            dataGridView1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.9000006F);
            label4.Location = new Point(23, 873);
            label4.Name = "label4";
            label4.Size = new Size(359, 72);
            label4.TabIndex = 6;
            label4.Text = "Nhân viên lập";
            // 
            // CboNhanVien
            // 
            CboNhanVien.Font = new Font("Segoe UI", 15.9000006F);
            CboNhanVien.FormattingEnabled = true;
            CboNhanVien.Location = new Point(410, 866);
            CboNhanVien.Name = "CboNhanVien";
            CboNhanVien.Size = new Size(827, 79);
            CboNhanVien.TabIndex = 7;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.9000006F);
            button2.Location = new Point(1263, 870);
            button2.Name = "button2";
            button2.Size = new Size(372, 83);
            button2.TabIndex = 8;
            button2.Text = "Lập hóa đơn";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1697, 1049);
            Controls.Add(button2);
            Controls.Add(CboNhanVien);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(CboKhachHang);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMain";
            Text = "Form1";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox CboKhachHang;
        private Button button1;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
        private ComboBox CboNhanVien;
        private Button button2;
    }
}
