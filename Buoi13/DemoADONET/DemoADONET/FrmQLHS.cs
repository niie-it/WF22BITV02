namespace DemoADONET
{
    public partial class FrmQLHS : Form
    {
        public FrmQLHS()
        {
            InitializeComponent();
        }

        private void FrmQLHS_Load(object sender, EventArgs e)
        {
            CboLop.ValueMember = "MaLop";
            CboLop.DisplayMember = "TenLop";
            CboLop.DataSource = DataProvider.TruyVan_LayDuLieu("SELECT MaLop, TenLop FROM Lop ORDER BY TenLop");

            //ép chọn lớp đầu tiên
            CboLop.SelectedIndex = 0;
        }

        private void CboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayHocSinhTheoLop();
        }

        void LayHocSinhTheoLop()
        {
            var sql = $"SELECT * FROM HocSinh WHERE MaLop = '{CboLop.SelectedValue}'";
            DgvHocSinh.DataSource = DataProvider.TruyVan_LayDuLieu(sql);
            //nếu lớp đó có học sinh thì lấy HS đầu tiên hiện lên
            if (DgvHocSinh.Rows.Count > 0)
            {
                HienThiThongTinMotHocSinh(DgvHocSinh.Rows[0]);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlInsert = $"INSERT INTO HocSinh(MaHS, TenHS, NgaySinh, DTB, MaLop) VALUES('{TxtMaHS.Text}',N'{TxtHoTen.Text}','{DtpNgaySinh.Value.ToString("yyyy-MM-dd")}','{TxtDiemTB.Text}','{CboLop.SelectedValue}')";
                //MessageBox.Show(sqlInsert);
                if (DataProvider.TruyVan_XuLy(sqlInsert))
                {
                    MessageBox.Show("Thêm mới thành công");
                    LayHocSinhTheoLop();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Chắc xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var sql = $"DELETE FROM HocSinh WHERE MaHS = '{TxtMaHS.Text}' ";
                if (DataProvider.TruyVan_XuLy(sql))
                {
                    MessageBox.Show("Xóa thành công!");
                    LayHocSinhTheoLop();
                    HienThiHocSinhDauTien();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        private void HienThiHocSinhDauTien()
        {
            throw new NotImplementedException();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            var sql = $"UPDATE HocSinh SET TenHS = N'{TxtHoTen.Text}', NgaySinh='{DtpNgaySinh.Value.ToString("yyyy-MM-dd")}', DiaChi = N'{TxtDiaChi.Text}', MaLop='{CboLop.SelectedValue}' WHERE MaHS='{TxtMaHS.Text}' ";
            if (DataProvider.TruyVan_XuLy(sql))
            {
                MessageBox.Show("Sửa thông tin thành công!");
                LayHocSinhTheoLop();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void DgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dr = DgvHocSinh.Rows[e.RowIndex];
                HienThiThongTinMotHocSinh(dr);
            }
        }

        private void HienThiThongTinMotHocSinh(DataGridViewRow dr)
        {
            TxtMaHS.Text = dr.Cells[0].Value.ToString();
            TxtHoTen.Text = dr.Cells[1].Value.ToString();
            DtpNgaySinh.Value = DateTime.Parse(dr.Cells[2].Value.ToString());
            TxtDiaChi.Text = dr.Cells[3].Value.ToString();
            TxtDiemTB.Text = dr.Cells[4].Value.ToString();
        }
    }
}
