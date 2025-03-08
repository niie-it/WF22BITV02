namespace MyControlLibrary
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        DateTime startTime;
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)//đang chạy
            {
                timer1.Enabled = false;
                btnLAP.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
                btnLAP.Enabled = true;
                startTime = DateTime.Now;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var myTime = DateTime.Now - startTime;
            lblDongHo.Text = $"{myTime.Hours.ToString("00")}:{myTime.Minutes.ToString("00")}:{myTime.Seconds.ToString("00")} {myTime.Milliseconds.ToString("000")}";
        }

        private void btnLAP_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter("Records.txt", true))
            {
                sw.WriteLine(lblDongHo.Text);
            }
        }
    }
}
