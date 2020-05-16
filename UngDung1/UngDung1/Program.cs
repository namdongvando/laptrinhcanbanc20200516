using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UngDung1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region code xin chao
            //Console.WriteLine("xin chao;");
            //Console.WriteLine("nhap ho ten");
            //string hoTen = Console.ReadLine();
            //Console.WriteLine("xin chao " + hoTen);
            //Console.WriteLine(@"xin
            //chao {0}", hoTen);
            #endregion
            #region xat dinh cham le
            Console.WriteLine("nham so nguyen duong ");
            string soNguyen = Console.ReadLine();
            int n = int.Parse(soNguyen);
            if (n % 2 == 0)
            {
                Console.WriteLine("{0} la so chan", n);
            }
            else {
                Console.WriteLine("{0} la so le", n);

            }

            #endregion


            Console.ReadKey();


        }
    }
}
