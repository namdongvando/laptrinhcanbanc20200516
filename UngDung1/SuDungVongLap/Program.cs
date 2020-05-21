using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungVongLap
{
    class Program
    {
        static void Main(string[] args)
        {
            //SuDungVongLapFor();
            //TinhDienTichHinhVuong();
            //TinhDienTichHinhChuNhat();
            //TinhDienTichHinhTron();

            //TinhTongTu1ToiN();

            //TinhNGiaiThua();
            //BangCuuChuong();
            //BangCuuChuong1();
            Menu();


        }

        private static void Menu()
        {
            Console.WriteLine("1 tinh tong tu 1 toi n ");
            Console.WriteLine("2 tinh giai thua ");
            Console.WriteLine("3 xuat bang cuu chuong ");
            Console.WriteLine("4 tinh dien tich hinh vuong ");
            Console.WriteLine("5 tinh dien tich hinh chu nhat ");
            Console.WriteLine("6 tinh dien tich hinh tron ");
            Console.WriteLine("Chon Chuong Trinh: ");
            string chon = Console.ReadLine();
            if (chon == "exit")
                return;

            Console.WriteLine(chon);
            switch (chon) {
                case "1":
                    TinhTongTu1ToiN();
                    break;
                case "2":
                    TinhNGiaiThua();
                    break;
                case "3":
                    BangCuuChuong();
                    break;
                case "4":
                    TinhDienTichHinhVuong();
                    break;
                case "5":
                    TinhDienTichHinhChuNhat(); 
                    break;
                case "6":
                    TinhDienTichHinhTron();
                    break;
            }
            Menu();

        }

        private static void BangCuuChuong1()
        {
            for (int j = 2; j <= 9; j++)
            {
                Console.WriteLine("xuat bang cuu chuong {0}",j);
                for (int i = 1; i <= 10; i++)

                {
                    Console.WriteLine("{0} x {1} = {2}", j, i, j * i);
                } 

            }
        }

        private static void BangCuuChuong()
        {
            for (int j = 2; j <= 9; j++)
            {
                Console.WriteLine("xuat bang cuu chuong {0}",j);
                for (int i = 1; i <= 10; i++)
                {
                    // 2 x 1 = 2
                    Console.WriteLine("{0} x {1} = {2}", j, i, j * i);
                }
            }
            
        }

        /// <summary>
        /// ham nay Tinh Giai Thua
        /// </summary>
        private static void TinhNGiaiThua()

        {
            Console.WriteLine("n la so nguyen duong");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine(n);
            int giaiThua = 1;
            for (int i = 1; i <= n; i++)

            {
                giaiThua *= i;
            }

            Console.WriteLine("giaiThua n la {0}", giaiThua);
        }

        private static void TinhDienTichHinhTron()
        {
            Console.WriteLine("nhap ban kinh");
            double r;
            double.TryParse(Console.ReadLine(), out r);
            Console.WriteLine("dien tich hinh tron la {0}",r * r* Math.PI );
        }

        private static void TinhDienTichHinhChuNhat()
        {
            Console.WriteLine("nhap a ");
            Console.WriteLine("nhap b ");
            double a;
            double b;
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("dien tich hinh chu nhat la {0}", a * b);


        }

        private static void TinhDienTichHinhVuong()
        {
            Console.WriteLine("nhap canh ");
            double canh;
            double.TryParse(Console.ReadLine(), out canh);
            Console.WriteLine("dien tich hinh vuong la {0}",canh*canh);


        }

        private static void TinhTongTu1ToiN()
        {
            Console.WriteLine("so nguyen N");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine(n);
            int tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += i;
                // tong = tong +i;
            }
            Console.WriteLine("tong tu 1 => n la:{0}",tong);

        }

        private static void SuDungVongLapFor()
        {
            for (int i = 0; i <= 99; i++)

            {
                Console.WriteLine("=========");
                Console.WriteLine("xin chao");
                Console.WriteLine("gia tri cua i la{0}", i);
                if (i % 2 == 0)
                {
                    Console.WriteLine(" {0} la so chan==", i);
                }
                else
                {
                    Console.WriteLine(" {0} la so le ", i);
                }
                Console.WriteLine("=========");

            }
        }
    }
}
