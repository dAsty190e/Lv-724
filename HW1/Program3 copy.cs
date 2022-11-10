using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radius of a circle: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double pi = 3.14;
            double l = 2 * pi * r;
            double s = pi * r * r;
            double v = 4 / 3 * pi * r * r * r;
            Console.Write("L: ");
            Console.WriteLine(string.Format("{0:F2}", l));
            Console.Write("S: ");
            Console.WriteLine(string.Format("{0:F2}", s));
            Console.Write("V: ");
            Console.WriteLine(string.Format("{0:F2}", v));
            Console.ReadKey();
        }
    }
}

