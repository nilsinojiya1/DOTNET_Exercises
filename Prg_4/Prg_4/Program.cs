using System;
/*
 * @Nil_Sinojiya
 * Swap Number
 */
namespace Prg_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Given Number:- ");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);
            Console.ReadLine();
        }
    }
}
