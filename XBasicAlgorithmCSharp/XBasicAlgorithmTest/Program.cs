using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XBasicAlgorithmCSharp;

namespace XBasicAlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    int i = int.Parse(Console.ReadLine());
            //    int i2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine(XCommonHelper.Max(i, i2));
            //}

            List<int> list = new List<int>();
            for (int i = 0; i < 10000000; i++)
            {
                list.Add(i);
            }

            while (true)
            {
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine(XCommonHelper.BinarySearch(list, value));
            }
        }
    }
}
