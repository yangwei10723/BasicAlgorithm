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
            while (true)
            {
                int i = int.Parse(Console.ReadLine());
                int i2 = int.Parse(Console.ReadLine());
                Console.WriteLine(XCommonHelper.Max(i, i2));
            }
        }
    }
}
