/*
 * @Nil_Sinojiya
 * Write a C# program to generate divide by zero exception and also handle this
exception.*/

using System;

namespace Prg_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine()); 
                int n = num1 / num2;
                Console.WriteLine(n);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
