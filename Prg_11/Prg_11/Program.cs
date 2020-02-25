/*
 * @Nil_Sinojiya
 * Write a C# program to copy data from one file to another using
StreamReader and StreamWriter class.
*/

using System;
using System.IO;

namespace Prg_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "E:\\Study\\SEM6\\DOTNET\\Programs\\file1.txt";

            StreamReader reader = new StreamReader(@file);
            int n = 0;
            string line = reader.ReadToEnd();
            Console.WriteLine(line);
            StreamWriter writer = new StreamWriter(@"E:\Study\SEM6\DOTNET\Programs\file2.txt", append: false);
            writer.Write(line);
            writer.Flush();
            writer.Close();
            reader.Close();
            Console.WriteLine();
        }

    }
}
