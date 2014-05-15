using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse3.cs
{
    class Program
    {

        public static void reverse(ref int a, ref int b, ref int c)
        {
            int temp = a;
            a = c;
            c = temp;
        }

        static void Main(string[] args)
        {
            int x = 1, y = 2, z = 3;

            reverse(ref x, ref y, ref z);

        }
    }
}
