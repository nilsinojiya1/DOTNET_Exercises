/*
 * @Nil_Sinojiya
 * Write a C# Program to List Files in a Directory.
 * */
using System;
using System.IO;

namespace Prg_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"E:\\study");
            Console.WriteLine("Files in directory");
            foreach (string name in files)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
