namespace DemoCommonControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGhiFile_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Title = "Lưu file";
            dlg.Filter = "C#|*.cs|Văn bản|*.txt|Tất cả|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(dlg.FileName);
                File.WriteAllText(dlg.FileName, TxtVanBan.Text);
            }
        }

        private void BtnDocFile_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Mở file";
            dlg.Filter = "C#|*.cs|Văn bản|*.txt|Tất cả|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TxtVanBan.Text = File.ReadAllText(dlg.FileName);
            }
        }

        private void btnDoiFont_Click(object sender, EventArgs e)
        {
            var dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowApply = true;
            dlg.Apply += new EventHandler(XuLyApplyFont);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TxtVanBan.Font = dlg.Font;
                TxtVanBan.ForeColor = dlg.Color;
            }
        }

        private void XuLyApplyFont(object? sender, EventArgs e)
        {
            var dlg = sender as FontDialog;
            TxtVanBan.Font = dlg.Font;
            TxtVanBan.ForeColor = dlg.Color;
        }

        private void BtnDoiMau_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TxtVanBan.BackColor = dlg.Color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //set timer Enable=True, Interval=1000ms
            labelDongHo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss t");
        }
    }
}
