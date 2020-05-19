using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLoaiHocTap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap diem");
            double diem;
            double.TryParse(Console.ReadLine(), out diem);
            Console.WriteLine(diem);
            if (diem >= 0 && diem <= 10)
            {
                if (diem < 3.5)
                    Console.WriteLine("kem");
                else if (diem < 5)
                    Console.WriteLine("yeu");
                else if (diem < 6.5)
                    Console.WriteLine("TB");
                else if (diem < 8.5)
                    Console.WriteLine("kha");
                else if (diem <= 10)
                    Console.WriteLine("gioi");

            }
            else {
                Console.WriteLine("diem ko hop le");
            }

            if (diem >= 0 && diem <= 10)
            {
                if (diem < 3.5 && diem >=0)
                    Console.WriteLine("kem");
                if (diem < 5 && diem >=3.5)
                    Console.WriteLine("yeu");
                if (diem < 6.5 && diem >=5)
                    Console.WriteLine("TB");
                if (diem < 8.5 && diem >= 6.5)
                    Console.WriteLine("kha");
                if (diem >= 8.5)
                    Console.WriteLine("gioi");

            }
            else { Console.WriteLine("diem ko hop le"); }

        }
    }
}
