using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHCN
{
    public abstract class HinhHoc
    {
        public double DienTich { get; set; }
        public double ChuVi { get; set; }

        public abstract void tinhDienTichChuVi();
    }

    public class HinhChuNhat : HinhHoc
    {
        public double Dai { get; set; }
        public double Rong { get; set; }

        public override void tinhDienTichChuVi()
        {
            DienTich = Dai * Rong;
            ChuVi = (Dai + ChuVi) * 2;
        }

        public override string ToString()
        {
            return $"HCN D={Dai}, R={Rong}, S={DienTich}, P={ChuVi}";
        }
    }

    public class HinhTron : HinhHoc
    {
        public double BanKinh { get; set; }

        public override void tinhDienTichChuVi()
        {
            DienTich = BanKinh * BanKinh * Math.PI;
            ChuVi = 2 * BanKinh * Math.PI;
        }

        public override string ToString()
        {
            return $"Tròn R = {BanKinh}, S = {DienTich}, P = {ChuVi}";
        }
    }
}
