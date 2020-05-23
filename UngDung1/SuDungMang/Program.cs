using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungMang
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimSoLonNhatTronMang();
            //TestMang();
            TimPhanTuMang();

        }

        private static void TimPhanTuMang()
        {
            int[] a = { 21, 23, 342, 42, 1, 134, 12 };
            int tim;
            bool kt = false;
            Console.WriteLine("nhap gia tri ban muon tim ");
             string nhap=Console.ReadLine();
            if (nhap == "exit")
                return;
            int.TryParse(nhap , out tim);
            for (int i = 0; i < a.Length; i++)
            {
                if (tim == a[i])
                {
                    Console.WriteLine("{0} o vi tri thu {1}",tim ,i);
                    kt = true;
                }
            }
            if (kt == false) 
            {
                Console.WriteLine("ko co gia tri trong mang");
            }
            TimPhanTuMang();

        }

        private static void TimSoLonNhatTronMang()
        {
            int[] a = { 2342, 3, 423, 4, 23, 42, 3};
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            Console.WriteLine("{0} la so nho nhat ", min);

            
            Console.WriteLine("{0} la so lon nhat ",max );
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    Console.WriteLine("{0} la so chan  ", a[i]);
            }
        }

        private static void TestMang()
        {
            int[] a = { 1, 2, 3, 4, 34, 3, 4, 3, 34, 5, 4 };

            int[] b = new int[6];


            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("nhap pt thu {0}", i);
                int.TryParse(Console.ReadLine(), out b[i]);

            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
