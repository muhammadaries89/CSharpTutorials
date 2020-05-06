using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Operation or Implicit Type Casting

            Int32 i1 = 9;
            Double d1 = i1;

            Console.WriteLine("Implicit Intege Before:" + i1);
            Console.WriteLine("Implicit Double After Type Casting:" + d1);

            //Explicit Operation or Explicit Type Csting

            Double d2 = 15.89;
            Int32 i2 = (int) d2;

            Console.WriteLine("Explicit Double Before:" + d2);
            Console.WriteLine("Explicit Integer After Type Casting:" + i2);


            Int32 i3 = 85;
            Double d3 = 47.25;
            Boolean bool1 = true;

            Console.WriteLine("Convert Method ToString() " + Convert.ToString(i3));
            Console.WriteLine("Convert Method ToDouble() " + Convert.ToDouble(i3));
            Console.WriteLine("Convert Method ToInt() " + Convert.ToInt32(d3));
            Console.WriteLine("Convert Method ToString() " + Convert.ToString(bool1));
            Console.WriteLine("Convert Method ToInt() " + Convert.ToInt32(bool1));


            Console.Read();
        }
    }
}
