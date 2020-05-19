using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraNhapSo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;

            bool kt = double.TryParse("123", out a);
            if (kt == true)
            {
                Console.WriteLine("la so");
            }
            else {
                Console.WriteLine("khong la so");

            }

            Console.WriteLine(a);



        }
    }
}
