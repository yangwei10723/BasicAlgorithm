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
            return value != 0 && ((value & (value - 1)) == 0);
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

        public static int Min(int x, int y)
        {
            //return y ^ ((x ^ y) & -(x < y));
            int charBit = 4;
            return y + ((x - y) & ((x - y) >> (sizeof(int) * charBit - 1)));    // only works when int.minvalue < x - y < int.maxvalue
        }

        public static int Max(int x, int y)
        {
            //return x ^ ((x ^ y) & -(x < y));
            int charBit = 4;
            return x - ((x - y) & ((x - y) >> (sizeof(int) * charBit - 1)));    // only works when int.minvalue < x - y < int.maxvalue
        }


        public static int BinarySearch(List<int> list, int value)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left <= right && left < list.Count && right < list.Count)
            {
                int mid = (left + right) >> 1;
                if (value > list[mid])
                {
                    left = mid + 1;
                }
                else if (value < list[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
