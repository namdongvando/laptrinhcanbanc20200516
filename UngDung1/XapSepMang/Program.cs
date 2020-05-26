using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XapSepMang
{
    class Program
    {
        static void Main(string[] args)
        {
            //HoanVi();

            //XapSepMang1();
            //XapSepMang2();
            //NhapMang();
            XapSepMang3();
        }

        private static void XapSepMang3()
        {
            int[] a = { 23, 32, 42, 3, 42, 3, 49, 89 };
            for (int j = 0; j < a.Length; j++)
            {
                int max = j;
                for (int i = j; i < a.Length; i++)
                {
                    if (a[max] > a[i])
                        max = i;

                }
                int tam = a[max];
                a[max] = a[j];
                a[j] = tam; 

                //Console.WriteLine("lon nhat trong mang la {0}", max);

            }
            
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);

            }
        }

        private static void XapSepMang2()
        {
            int[] a = { 23, 32, 42, 3, 42, 3, 49, 89 };
            
            int i = 0;
            while (true)
            {
                if (a[i] > a[i + 1])
                {
                    int tam;
                    tam = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = tam;
                    i = 0;

                }
                else
                {
                    i++;
                }

                if (i + 1 >= a.Length) 
                {
                    break;
                }
            }
            for (int j = 0; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);
            }
        }

        private static void NhapMang()
        {
            Console.WriteLine("nhap so phan tu mang");
            int soPhanTuMang;
            int.TryParse(Console.ReadLine(), out soPhanTuMang);
            int[] a = new int[soPhanTuMang];
            //a[0] = 1;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(" nhap phan tu mang {0}", i);
                int.TryParse(Console.ReadLine(), out a[i]);
            }
            Console.WriteLine("mang vua nhap la ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static void HoanVi()
        {
            int a = 8;
            int b = 4;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a={0},b={1}", a, b);
        }

        private static void XapSepMang1()
        {
            int[] a = { 23, 32, 42, 3, 42, 3, 49, 89 };
            for (int i = 0; i < a.Length-1;)
            {
                if (a[i] > a[i + 1])
                {
                    int tam;
                    tam = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = tam;
                    i = 0;

                }
                else
                    i++;
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            
        }
    }
}
