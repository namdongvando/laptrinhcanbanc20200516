using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("nhap b");
            double b = Double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("phuong trinh Co nghiem la {0}",(-b/a));
            }
        }
    }
}
