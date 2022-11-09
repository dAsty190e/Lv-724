using System;

namespace Classwork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Double a, b;
            Console.Write("Enter a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            //Output
            Console.WriteLine("Sum {0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("Sub  " + a + "-" + b + "= " + (a - b));
            Console.WriteLine($"Mult {a} * {b} = {a * b}");
            Console.WriteLine("{0} / {1} = {2:F2}", a, b, a / b);
            Console.ReadKey();
        }
    }
}
