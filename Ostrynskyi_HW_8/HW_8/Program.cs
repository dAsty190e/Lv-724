using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_HW_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Please, enter Circle or Square");
                string input = Console.ReadLine();
                if (input == "Circle")
                {
                    Console.WriteLine("Enter the name of Circle: ");
                    string circleName = Console.ReadLine();
                    Console.WriteLine("Enter radius: ");
                    int circleRadius = Convert.ToInt32(Console.ReadLine());

                    shapeList.Add(new Circle(circleName, circleRadius));
                }
                else if (input == "Square")
                {
                    Console.WriteLine("Enter the name of Square: ");
                    string squareName = Console.ReadLine();
                    Console.WriteLine("Enter side of Squere: ");
                    int squareSide = Convert.ToInt32(Console.ReadLine());

                    shapeList.Add(new Square(squareName, squareSide));
                }
                else
                {
                    Console.WriteLine("Your data is not correct.Write circle or square");
                    i--;
                }
                foreach (Shape c in shapeList)
                {
                    c.Print();
                }
                var result = shapeList.FirstOrDefault(s => s.Perimeter() == shapeList.Max(s1 => s1.Perimeter()));
                Console.WriteLine("\nShape {0} have max perimeter: {1:F2}", result.Name, result.Perimeter());
                Console.WriteLine("\nSorting list by area:");
                shapeList.Sort();
                foreach (Shape c in shapeList)
                {
                    c.Print();
                }
            }
        }
    }
}