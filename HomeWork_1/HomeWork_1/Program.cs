using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task1
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Perimeter of the square is: " + 4 * a);
            Console.WriteLine("Area of the square is: " + a * a);

            //Task2
            //Announce variables
            string name;
            int age;

            //ToDisplayName
            Console.WriteLine("What is your name ?");
            name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("How old are you " + name + "?");

            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + " " + age);


            //Task3
            //Announce the variables

            double length, area, volume;
            double pi = 3.14;
            double r = Convert.ToDouble(Console.ReadLine());

            //Calculate the circle lenght

            length = 2 * pi * r;
            Console.WriteLine("The length of the Circle is: " + length);

            //Calculate the circle lenght

            area = pi * r * r;
            Console.WriteLine("The area of the Circle is: " + Math.Round(area));

            //Calculate the circle volume 

            volume = 4 / 3 * pi * r * r * r;
            Console.WriteLine("The volume of the Circle is: " + volume);
        }
    }
}
