using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse4.cs
{
    class Program
    {

        public static void reverse(ref int a, ref int b, ref int c, ref int d)
        {
            int temp = a;
            a = c;
            c = temp;
        }

        static void Main(string[] args)
        {
            int w = 1, x = 2, y = 3, z = 4;

            reverse(ref w, ref x, ref y, ref z);

        }
    }
}
