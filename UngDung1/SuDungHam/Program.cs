using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuDungHam
{
    class Program
    {
        static void Main(string[] args)
        {
            //XinChao();
            //XinChao("nguyen van teo");
             string cauXinChao=XinChao("nguyen van teo");
            Console.WriteLine(cauXinChao);
        }
        /// <summary>
        /// xin chao co tham so
        /// </summary>
        /// <param name="v"></param>
        private static string XinChao(string v)
        {
            return String.Format ("xin chao:{0}", v);
        }

        private static void XinChao()
        {
            Console.WriteLine("xin chao");
        }
    }
}
