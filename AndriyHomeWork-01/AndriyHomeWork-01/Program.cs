using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndriyHomeWork_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.Write("Input the square side length: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());//double sideLength = double.Parse(Console.ReadLine());
            double area = sideLength * sideLength;
            const int squareSides = 4;
            double perimeter = sideLength * squareSides;
            Console.WriteLine($"Square with side length: {sideLength}\n" +
                              $"has an Area equal to {area} and Perimeter equal to {perimeter}");
            Console.WriteLine();

            //Task 2
            string name;
            int age;
            Console.Write("Hello User! What is you name? ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}! How old are you?", name);
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("That`s great, {0}, you are still very fresh and nice looking for all yours {1}!", name, age);
            Console.WriteLine();

            //Task 3
            Console.Write("Lets count some circle parameters. Input the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double PI = Math.PI;
            double length = 2*PI*radius; // 2*pi*r
            double circleArea = PI*Math.Pow(radius, 2);//pi*r*r
            double volume = 4*(PI * Math.Pow(radius, 3))/3;//  4/3*pi*r*r*r
            //Console.WriteLine($"Circle with radius {radius} has: \nArea: {Math.Round(area, 2)} \nLength: {Math.Round(length, 3)} \nVolume: {Math.Round(volume, 4)}");
            Console.WriteLine(String.Format("Cirlce with radius {0} " +
                "\nhas Area equal to {1:N2} " +
                "\nLength equal to {2:N2} " +
                "\nVolume equal to {3:N2}", radius, circleArea, length, volume));


            Console.WriteLine("Pi is equal {0}", Math.PI);
            


            Console.ReadKey();
        }
    }
}
