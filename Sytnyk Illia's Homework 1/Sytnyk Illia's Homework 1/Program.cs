using System;

namespace Sytnyk_Illia_s_Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.Write("Enter size of square's side = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Square's area= " + Math.Pow(a, 2));
            Console.WriteLine("Square's area= {0:F2}", Math.Pow(a, 2));

            Console.WriteLine("Square's perimeter: {0} * {1} = {2}", a, 4, a * 4);
            Console.WriteLine("Square's Perimeter= " + a * 4);

            Console.ReadKey();



            //Task 2
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you, " + name + "?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("You are {0}, {1} years old", name, age);
            Console.ReadKey();



            //Task 3
            Console.WriteLine();
            Console.Write("Radius size = ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lenth: {0} * {1} * {2} = {3}", 2, Math.PI, r, 2 * Math.PI * r);
            Console.WriteLine("Lenth: {0} * {1} * {2} = {3:F2}", 2, Math.PI, r, 2 * Math.PI * r);
            Console.WriteLine("-------------------------");

            Console.WriteLine($"Area: {Math.PI} * {r} * {r} = {Math.PI * r * r}");
            Console.WriteLine($"Area: {Math.PI} * {r} * {r} = {Math.PI * r * r:F2}");
            Console.WriteLine("-------------------------");

            double drib = (double)4 / 3;
            Console.WriteLine("Volume: {0}  * {1} * {2} = {3}", drib, Math.PI, Math.Pow(r, 3), drib * Math.PI * r * r * r);
            Console.WriteLine("Volume: {0}  * {1} * {2} = {3:F2}", drib, Math.PI, Math.Pow(r, 3), drib * Math.PI * r * r * r);

            Console.ReadKey();
        }
    }
}
