using DemoEFCore.Models;

namespace DemoEFCore
{
    public partial class FrmMain : Form
    {
        QlbanHangContext _ctx;
        public FrmMain()
        {
            InitializeComponent();
            _ctx = new QlbanHangContext();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CboKhachHang.DisplayMember = "TenCty";
            CboKhachHang.ValueMember = "MaKh";
            CboKhachHang.DataSource = _ctx.KhachHangs;

            CboNhanVien.DisplayMember = "HoTen";
            CboNhanVien.ValueMember = "MaNV";
            CboNhanVien.DataSource = _ctx.NhanViens.Select(p => new { 
                MaNV = p.MaNv, HoTen = $"{p.Ho} {p.Ten}"
            });
        }
    }
}
