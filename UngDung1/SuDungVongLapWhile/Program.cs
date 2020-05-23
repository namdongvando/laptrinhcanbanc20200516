using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungVongLapWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            TimUCLN();

            //NhapSoNguyenDuong();
           // Menu();

        }

        private static void TimUCLN()
        {
            int a = 6;
            int b = 9;
            // khi a va b  > 0
            while (a * b > 0) {
                if (a > b) {

                    a = a % b;
                }else
                {
                }
            }

            Console.WriteLine("Ucln la {0}", a + b);


        }

        private static void Menu()
        {
            Console.WriteLine("1 .Vong Lap While");
            Console.WriteLine("2 .Nhap so Nguyen Duong");
            Console.WriteLine("nhap :");
            string chon = Console.ReadLine();
            if (chon == "exit")
                return;

            switch (chon) {
                case "2":
                    NhapSoNguyenDuong();
                    break;
                case "1":
                    VongLapWhileCoBan();
                    break;
                default:
                    return;

            }
            Menu();

        }

        private static void NhapSoNguyenDuong()
        {
            int a;
            Console.WriteLine("Nhap so nguyen duong");
            while (true)
            {
                bool kt = int.TryParse(Console.ReadLine(), out a);
                if (kt == true)
                {
                    if (a <= 0)
                    {
                        kt = false;
                    }
                    else
                    {
                        break;
                    }
                }
                if (kt == false)
                    Console.WriteLine("Nhap Lai");
            }
        }
        private static void NhapSoNguyenDuong1()
        {
            int a;
            Console.WriteLine("Nhap so nguyen duong");
            //bool kt =  int.TryParse(Console.ReadLine(), out a);
            //if (kt == true)
            //    if (a == 0)
            //        kt = false;
            while (true)
            {

                bool kt = int.TryParse(Console.ReadLine(), out a);
                //if (kt == true)
                //    kt = (a == 0) ? false : true;
                if (kt == true)
                {
                    if (a == 0)
                    {
                        kt = false;
                    }
                    else
                    {
                        // ? true
                        break;
                    }
                }
                if (kt == false)
                    Console.WriteLine("Nhap Lai");

            }
        }

        private static void VongLapWhileCoBan()
        {
            int i=0;
            while (i<=99)
            {
                Console.WriteLine("xin chao");
                i++;
            } 
        }
    }
}
