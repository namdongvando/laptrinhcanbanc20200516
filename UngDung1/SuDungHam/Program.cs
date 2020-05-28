using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuDungHam
{
    class Program
    {
        static void Main(string[] args)
        {
            //XinChao();
            //XinChao("nguyen van teo");
            //PhuongTrinhbac1();
            //int a =  NhapSoNguyen("Nhap so nguyen");
            //PhuongTrinhbac2();
            //UocChungLonNhat();
            //string cauXinChao = XinChao("nguyen van teo");
            //Console.WriteLine(cauXinChao);
            //double a = NhapSo("nhap so a ");
            //TongTu1DenN();
            //GiaiThua();
            //tinhgiaiThua1(5);
            Console.WriteLine(tinhgiaiThua1(5));
        } 


        private static int tinhgiaiThua1(int v)
        {
            if (v==1)

            {
                return 1;
            }
            return v * tinhgiaiThua1(v - 1);
        }

        private static void GiaiThua()
        {
            int n = NhapSoNguyen("giai thua la so nguyen ");
            int  giaiThua= tinhgiaiThua(n);
            Console.WriteLine("giai thua la {0}", giaiThua);
        }

        private static int tinhgiaiThua(int n)
        {
            int giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }

        private static void TongTu1DenN()
        {
            int n = NhapSoNguyen("n la so nguyen duong");
            int tong = TinhTongTu1DenN(n);
            Console.WriteLine("tong tu 1 den n la {0} ",tong);
        }

        private static int TinhTongTu1DenN(int n)
        {
            int tong = 0;
            for (int i = 0; i <= n; i++)
            {
                tong = tong + i;
            }
            return tong;
        }

        private static void UocChungLonNhat()
        {
            int a = NhapSoNguyen("nhap so nguyen duong a");
            int b = NhapSoNguyen("nhap so nguyen duong b");
            int ucln = TimUCLN(a, b);
            Console.WriteLine("Uoc chung lon nhat la ");

        }

        private static int TimUCLN(int a, int b)
        {
            while (a * b > 0)
            {
                if (a > b)
                    b = b % a;
                else
                    a = a % b;
            }
            return a + b;
        }

        private static int NhapSoNguyen(string thongBao) {
            int a;
            bool kt = true;
            do
            {
                Console.WriteLine(thongBao);
                kt = int.TryParse(Console.ReadLine(), out a);
                if (a<=0)
                {
                    kt = false;
                }

            } while (kt == false); 

            return a;
        }

        private static void PhuongTrinhbac2()
        {
            double a = NhapSo("nhap So a");
            double b = NhapSo("nhap So b");
            double c = NhapSo("nhap So c");
            try
            {
                double[] nghiem = GiaiPhuongTrinhBac2(a, b, c);
                Console.WriteLine(nghiem[0]);
                Console.WriteLine(nghiem[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static double[] GiaiPhuongTrinhBac2(double a, double b, double c)
        {
            double[] nghiem = new double[2];
            if (a == 0)
            {
                throw new Exception("kpptb2");
            }
            
            double d = b * b - 4 * a * c;
            //d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                throw new Exception("ptvn");
            }
            
            nghiem[0] = (-b + Math.Sqrt(d)) / (2 * a);
            nghiem[1] = (-b - Math.Sqrt(d)) / (2 * a);

            return nghiem;
            
        }

        private static void PhuongTrinhbac1()
        {
            double a = NhapSo("Nhap So a");
            double b = NhapSo("Nhap So b");
            try
            {
                double x = GiaiPhuongTrinhBac1(a, b);
                Console.WriteLine(x);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private static double GiaiPhuongTrinhBac1(double a, double b)
        {
            if (a == 0)
                if (b == 0)
                    throw new Exception("ptvsn");
                else
                    throw new Exception("ptvn");
            return -b / a;
        }

        private static double NhapSo(string v)
        {
            double a;
            bool kt;

            do
            {
                Console.WriteLine(v);
                kt = double.TryParse(Console.ReadLine(), out a);

            }
            while (kt == false);
            return a;

        }

        /// <summary>
        /// xin chao co tham so
        /// </summary>
        /// <param name="v"></param>
        private static string XinChao(string v)
        {
            return String.Format("xin chao:{0}", v);
        }

        private static void XinChao()
        {
            Console.WriteLine("xin chao");
        }
    }

    internal class TimUocChungLonNhatCuaaVab
    {
    }
}
