/*
 * @Nil_SInojiya
 * Write a console application to Perform Celsius to Fahrenheit Conversion and Fahrenheit to Celsius conversion.
 */
using System;

namespace Prg_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Temp. in Celsius:- ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("Temp. in fahrenheit:- " + ((celsius * 9) / 5 + 32));

            Console.Write("Enter Temp. in fahrenheit:- ");
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.Write("Temp. in celsius:- " + ((fahrenheit - 31)*5)/9);

        }
    }
}
