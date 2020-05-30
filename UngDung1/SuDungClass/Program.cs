using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungClass
{
    class Program
    {
        static void Main(string[] args)
        {
            XinChao xinchao = new XinChao();

            Console.WriteLine(xinchao.chao("nguyen van teo"));
            try
            {
                PhuongTrinhbacNhat ptb1 = new PhuongTrinhbacNhat();
                ptb1.SoA = 0;
                ptb1.SoB = 3;
                ptb1.GiaiPhuongTrinh();
                Console.WriteLine("nghiem cua phuong trinh la {0}",ptb1.NghiemX);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
                


        }
    }
}
