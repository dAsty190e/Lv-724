using System;

namespace SeletskiyHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the square's side:");
            int a = Convert.ToInt32(Console.ReadLine());

            void squareCalculations(int side)
            {
                Console.WriteLine
                    (
                        "Perimeter of a square with a side of " + side + " is " + side * 4 + 
                        "\nArea of a square with a side of " + side + " is " + side * side
                    );
            }

            squareCalculations(a);

            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("How old are you, {0}?", name);

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You are {0} years old, {1}.", age, name);

            Console.WriteLine("Enter the radius of a circle:");

            double r = Convert.ToDouble(Console.ReadLine());

            void circleCalculations(double radius)
            {
                double length = 2 * Math.PI * radius;

                double area = 2 * Math.PI * Math.Pow(radius, 2);

                double volume = (4 / 3) * Math.PI * Math.Pow(radius, 3);

                Console.WriteLine
                    (
                        "Length of a circle with a radius of {0} is {1}. " +
                        "\nArea of a circle with the same radius is {2}, " +
                        "and volume of a ball with similar radius is {3}", 
                        radius, length, area, volume
                    );
            }

            circleCalculations(r);
        }
    }
}
