/*
 *@Nil_Sinojiya
 * Write a C# Program to Read Lines from a File until the End of File is Reached.
 * */
using System;
using System.IO;

namespace Prg_16
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("E:\\Study\\SEM6\\DOTNET\\Programs\\file1.txt");
            string line = null;
            while((line = reader.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
