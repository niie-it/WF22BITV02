using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02BT04_TruyenDuLieu
{
    public partial class FrmXuat : Form
    {
        public int SoDong { get; set; }
        public int SoCot { get; set; }
        const int BUTTON_SIZE = 100;
        const int SPACING = 20;
        public FrmXuat(int soDong = 1, int soCot = 1)
        {
            InitializeComponent();
            SoDong = soDong;
            SoCot = soCot;

            //gắn control (button) vô form
            Button btn;
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    btn = new Button()
                    {
                        Width = BUTTON_SIZE,
                        Height = BUTTON_SIZE,
                        Left = SPACING + (SPACING + BUTTON_SIZE) * j,
                        Top = SPACING + (SPACING + BUTTON_SIZE) * i,
                        Text = $"{i}, {j}"
                    };
                    btn.Click += XuLyClick;
                    btn.MouseHover += new EventHandler(HoChuotVoButton);
                    this.Controls.Add(btn);
                }
            }

            //Resize form
            this.Size = new Size
            {
                Width = 40 + SPACING + (SPACING + BUTTON_SIZE) * SoCot,
                Height = 80 + SPACING + (SPACING + BUTTON_SIZE) * SoDong,
            };
        }

        void XuLyClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            MessageBox.Show($"Vừa click ô {btn.Text}");
        }
        void HoChuotVoButton(object sender, EventArgs e)
        {
            var btn = sender as Button;
            this.Text = $"Button {btn.Text}";
        }
    }
}
