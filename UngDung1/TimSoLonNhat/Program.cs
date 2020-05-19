using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimSoLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a ");
            Double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("nhap b");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("nhap c");
            Double c = double.Parse(Console.ReadLine());
            double max = a;

            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
                
            }
            Console.WriteLine("Trong ba so {0},{1},{2} so lon nhat la {3}",
            a, b, c, max
            );
            Double min = a;
            if (min > b)

                min = b;
            if (min > c)

                min = c;
            Console.WriteLine("trong ba so {0},{1},{2} so nho nhat la {3}",
                a, b, c, min);




        }
    }
}
