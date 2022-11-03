using System;

namespace ConsoleApp1
{
    internal class HomeWork1
    {
        static int Main()
        {
            Console.WriteLine("Please, enter the length of a squere side: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int squere_perimeter = a * 4;
            int squere_area = a * a;

            Console.WriteLine($"Perimeter of the squere is: {squere_perimeter}");
            Console.WriteLine("The squere area is: {0}", squere_area);

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you, {0}", name);
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{name}, Your age is {age}");

            Console.Write("Enter a radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            const double PI = 3.14;
            double length = PI * 2 * radius;
            double area = PI * radius * radius;
            double volume = 4/3 * PI * radius * radius * radius;

            Console.WriteLine($"Circle parameters are:\n\tVolume: {volume}\n\tArea: {area}\n\tLength: {length}");

            return 0;
        }
    }
}
