/*
 * @Nil_Sinojiya
 * Write a C# program to demonstrate method overloading.
 */
using System;

namespace Prg_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = AddNum(5, 5);
            double num2 = AddNum(10.5, 6.26);
            Console.WriteLine("Int: " + num1);
            Console.WriteLine("Double: " + num2);
        }

        private static int AddNum(int x, int y)
        {
            return x + y;
        }
        static double AddNum(double x, double y)
        {
            return x + y;
        }
    }

 

  

}
