using System;
/*
 * @Nil_Sinojiya
 * Find Number is Odd or Even */
namespace Prg_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numbe:- ");
            int n = int.Parse(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("Given Number is Even.");
            }
            else
            {
                Console.WriteLine("Given Number is Odd");
            }
            Console.ReadLine();
        }
    }
}
