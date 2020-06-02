using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungClass
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron hinhTron = new HinhTron();
            hinhTron.BanKinh = 
                NhapSo("nhap Ban kinh hinh tron");
            Console.WriteLine(hinhTron.ChuVi());
            Console.WriteLine(hinhTron.DienTich());

            HinhVuong HinhVuong = new HinhVuong();
            HinhVuong.CanhA =
                NhapSo("nhap Canh a");
            Console.WriteLine(HinhVuong.ChuVi());
            Console.WriteLine(HinhVuong.DienTich());

            try
            {
                HinhTamGiac HinhTamGiac = new HinhTamGiac();
                HinhTamGiac.CanhA =
                    NhapSo("nhap Canh a");
                HinhTamGiac.CanhB =
                    NhapSo("nhap Canh b");
                HinhTamGiac.CanhC =
                    NhapSo("nhap Canh c");
                Console.WriteLine(HinhTamGiac.ChuVi());
                Console.WriteLine(HinhTamGiac.DienTich());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //PhuongTrinh();

        }

        private static void PhuongTrinh()
        {
            XinChao xinchao = new XinChao();

            try
            {
                double a = NhapSo("Nhap so a");
                double b = NhapSo("Nhap so b");
                double c = NhapSo("Nhap so c");
                PhuongTrinhBac2 ptb2 = new PhuongTrinhBac2(a, b, c);
                Console.WriteLine(ptb2.NghiemX1);
                Console.WriteLine(ptb2.NghiemX2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                PhuongTrinhbacNhat ptb1tt = new PhuongTrinhbacNhat(3, 2);
                Console.WriteLine(ptb1tt.NghiemX);

                PhuongTrinhbacNhat ptb1 = new PhuongTrinhbacNhat();
                ptb1.SoA = 0;
                ptb1.SoB = 3;
                ptb1.GiaiPhuongTrinh();
                Console.WriteLine("nghiem cua phuong trinh la {0}", ptb1.NghiemX);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static double NhapSo(string v)
        {
            double a;
            bool kt = false;
            do
            {
                Console.WriteLine(v);
                kt = double.TryParse(Console.ReadLine(), out a);
            } while (kt == false);
            return a;
        }
    }
}
