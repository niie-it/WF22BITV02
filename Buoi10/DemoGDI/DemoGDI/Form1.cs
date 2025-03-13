using System.Drawing.Drawing2D;

namespace DemoGDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawString("22BITV02 HRL", new Font("Tahoma", 18, FontStyle.Bold), new SolidBrush(Color.BlueViolet), 100, 100);

            var pen = new Pen(Color.Green, 5);
            g.DrawLine(pen, 150, 200, 550, 500);

            g.DrawRectangle(pen, 250, 250, 400, 250);
            var brush = new HatchBrush(HatchStyle.DarkHorizontal, Color.GreenYellow);
            g.FillRectangle(brush, 450, 450, 600, 450);
        }
    }
}
