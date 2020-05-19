using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap c");
            double c = double.Parse(Console.ReadLine());
            
            // khong6 phai ptb2
            if (a == 0)
            {
                Console.WriteLine("ko phai chuong trinh b2");
            }
            else {
                // la ptb2
                double d = b * b - 4 * a * c;
                d = Math.Pow(b, 2) - 4 * a * c;
                if (d >= 0) {
                    double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine("phuong trinh co nghiem x1={0} x2={1}",x1,x2);

                }
                else {
                    Console.WriteLine("phuong trinh vo nhiem");
                }
                
                




            }


        }
    }
}
