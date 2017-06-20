using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBasicAlgorithmCSharp
{
    public static class XCommonHelper
    {
        public static bool IsPowOfTwo(int value)
        {
            return (value & (value - 1)) == 0;
        }

        public static int FindCeilPowOfTwo(int value)
        {
            value--;
            value |= value >> 1;
            value |= value >> 2;
            value |= value >> 4;
            value |= value >> 8;
            value |= value >> 16;
            value++;
            return value;
        }
    }
}
