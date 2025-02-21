using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapMang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //khai báo ngoài sự kiện (trong class)
        List<int> myList = new List<int>();
        int soPhanTu = 0;

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            myList.Clear();
            soPhanTu = int.Parse(txtSoPhanTu.Text);

            var random = new Random();
            //khởi tạo mảng số nguyên ko trùng gồm soPhanTu
            while (myList.Count < soPhanTu)
            {
                int soNgauNhien = random.Next(1, 1001);
                if (!myList.Contains(soNgauNhien))
                {
                    myList.Add(soNgauNhien);
                }
            }

            txtKetQua.Text = $"Mảng: {string.Join(", ", myList)}";
        }

        private void btnXoaMang_Click(object sender, EventArgs e)
        {
            myList.Clear();
            txtKetQua.Text = $"Sau khi xóa mảng còn {myList.Count} phần tử";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int giaTriTim = int.Parse(txtGiaTri.Text);
            int viTriTimThay = myList.IndexOf(giaTriTim);
            if (viTriTimThay < 0)
            {
                txtKetQua.Text = $"Không tìm thấy {giaTriTim} trong mảng: {string.Join(", ", myList)}";
            }
            else
            {
                txtKetQua.Text = $"Tìm thấy {giaTriTim} tại vị trí {viTriTimThay} trong mảng: {string.Join(", ", myList)}";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int giaTriTim = int.Parse(txtGiaTri.Text);
            int viTriTimThay = myList.IndexOf(giaTriTim);
            if (viTriTimThay < 0)
            {
                txtKetQua.Text = $"Không tìm thấy {giaTriTim} trong mảng: {string.Join(", ", myList)}";
            }
            else
            {                
                txtKetQua.Text = $"Tìm thấy {giaTriTim} tại vị trí {viTriTimThay} trong mảng: {string.Join(", ", myList)}";
                myList.Remove(giaTriTim);
                txtKetQua.Text += $"\r\nSau khi xóa: {string.Join(", ", myList)}";
            }
        }
    }
}
