/*
 * @Nil_SInojiya
 * Write a C# program console application to define shape class and derive circle and rectangle from it to demonstrate inheritance.
*/
using System;


namespace Prg_20
{
    class Shape
    {
        public void Display()
        {
            Console.WriteLine("Class shape");
        }

    }
    class Rectangle : Shape
    {
        public void Display1()
        {
            Console.WriteLine("Class Rectangle ");
        }
    }

    class Circle : Shape
    {
        public void Display1()
        {
            Console.WriteLine("Class Circle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Display();
            r1.Display1();

            Circle c1 = new Circle();
            c1.Display();
            c1.Display1();

        }
    }
}
