/*
 * @Nil_Sinojiya
 * Create C# .Net console application to accept 10 numbers from user and find its average. Also handle IndexOutOfRangeException
 */
using System;

namespace Prg_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            double avg;
            Console.Write("Input the 10 numbers : \n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;
            Console.WriteLine("Average of given numbers:- "+avg);
        }
    }
}
