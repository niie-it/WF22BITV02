namespace Lab02BT04_TruyenDuLieu
{
    public partial class FrmNhapLieu : Form
    {
        public FrmNhapLieu()
        {
            InitializeComponent();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            int dong, cot;
            if (!int.TryParse(txtSoDong.Text, out dong) || dong < 1)
            {
                MessageBox.Show("Dòng không hợp lệ");
                txtSoDong.Focus();
                return;
            }
            if (!int.TryParse(txtSoCot.Text, out cot) || cot < 1)
            {
                MessageBox.Show("Cột không hợp lệ");
                txtSoCot.Focus();
                return;
            }
            var form = new FrmXuat(dong, cot);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
