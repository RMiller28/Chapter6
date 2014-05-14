﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToYards
{
    class Program
    {

        public static int InchesToFeet(int inches)
        {
            return (inches % 36) / 12;
        }
        public static int InchesToInches(int inches)
        {
            return inches % 12;
        }
        public static int InchesToYards(int inches)
        {
            return inches / 36;
        }
        static void Main(string[] args)
        {
            int inches = 67;

            //InchesToFeet(inches);
            //InchesToYards(inches);
            //InchesToInches(inches);

            int result = InchesToYards(inches);
            int result2 = InchesToFeet(inches);
            int result3 = InchesToInches(inches);

            Console.WriteLine("{0} Yards {1} Feet {2} Inches", result, result2, result3);

        }
    }
}