using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet
{
    class Program
    {

        public static void InchesToFeet(ref int inches4)
        {
            //Console.WriteLine("{0} Feet and {1} Inches", inches / 12, inches % 12);
            inches4 = 70;
        }

        
        static void Main(string[] args)
        {
            int inches = 67;

            InchesToFeet(ref inches);



        }

    }
}