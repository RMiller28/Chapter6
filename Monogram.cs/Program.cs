﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monogram
{
    class Program
    {
        public static void Monogram(char a, char b, char c)
        {

            Console.WriteLine("** {0}.{1}.{2}. **", a, b, c);

        }

        static void Main(string[] args)
        {
            char f1 = 'R', m1 = 'R', l1 = 'M', f2 = 'S', m2 = 'S', l2 = 'M';


            Monogram(f1, m1, l1);
            Monogram(f2, m2, l2);

        }
    }
}
