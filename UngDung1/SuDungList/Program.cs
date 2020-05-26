using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuDungList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = new List<int>();
            listInt.Add(3);
            listInt.Add(5);
            listInt.Add(6);
            listInt.Add(7);
            listInt.Add(8);
            listInt.Add(9);
            listInt.Add(10);
            listInt.Add(11);
            //listInt.RemoveAll(item => item>=7);
            for (int i = 0; i < listInt.Count; i++)
            {
                Console.WriteLine(listInt[i]);
            }
            foreach (var item in listInt)
            {
                Console.WriteLine(item);
            }
        }
    }
}
