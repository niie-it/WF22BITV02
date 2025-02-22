using System.Text;

namespace QuanLyHCN
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        List<HinhHoc> dsHinh = new List<HinhHoc>();

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (radHCN.Checked)
            {
                dsHinh.Add(new HinhChuNhat
                {
                    Dai = double.Parse(txtDai.Text),
                    Rong = double.Parse(txtRong.Text)
                });
            }
            else if (radHT.Checked)
            {
                dsHinh.Add(new HinhTron
                {
                    BanKinh = double.Parse(txtBanKinh.Text)
                });
            }

            HienThiDSHinh();
        }

        private void HienThiDSHinh()
        {
            var sb = new StringBuilder();
            foreach (var hinh in dsHinh)
            {
                hinh.tinhDienTichChuVi();
                sb.Append($"{hinh}\r\n");
            }

            txtKetQua.Text = sb.ToString();            
        }
    }
}
