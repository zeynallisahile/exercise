using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0)
                return true;

            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
                return true;

            return false;
        }

        public static bool HasContainsDigit(this string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                    return true;
            }
                   return false;
        }

        public static void IsCapitalize(this string str)
        {

        }

        public static void GetValueIndexes(this string str, char c)
        {
            Array.Resize();
        }
    }
}
