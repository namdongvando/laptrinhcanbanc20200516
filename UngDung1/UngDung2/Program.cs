using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UngDung2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap nam sinh");
            int namSinh = int.Parse(Console.ReadLine());

            DateTime namHienTai = DateTime.Now;
             
            int tuoi = namHienTai.Year - namSinh;

            



            Console.WriteLine("ban {0} tuoi",tuoi);
           
        }
    }
}
