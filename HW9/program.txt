using System;
using System.Collections.Generic;

namespace Homework8
{
    class Program
    {
        static void Main()
        {
            string userInput;
            List<Shape> shapes = new List<Shape>();
        a:
            try
            {
                do
                {
                    Console.WriteLine("==================================");
                    Console.WriteLine("To add circle, type in \"circle\"");
                    Console.WriteLine("To add squere, type in \"squere\"");
                    Console.WriteLine("Type in sort to sort the list");
                    Console.WriteLine("Type in quit to end program");
                    Console.WriteLine("Type display, to display all shapes");
                    Console.WriteLine("==================================\n");
                    userInput = Console.ReadLine().ToLower();

                    switch (userInput)
                    {
                        case "circle":
                            Circle(ref shapes);
                            break;

                        case "squere":
                            Square(ref shapes);
                            break;

                        case "sort":
                            shapes.Sort();
                            break;

                        case "display":
                            Display(ref shapes);
                            break;

                        case "quit":
                            Console.WriteLine("Bye!");
                            break;

                        default:
                            Console.WriteLine("No such figure");
                            break;
                    }
                }
                while (userInput != "quit");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto a;

            }
            
            
        }

        // Helper functions
        static void Circle(ref List<Shape> shapes)
        {
            Console.WriteLine("Enter name and radius seperated by space: ");
            string[] temp = Console.ReadLine().Split(' ');
            string name = temp[0];
            decimal radius = Convert.ToDecimal(temp[1]);
            shapes.Add(new Circle(name, radius));
        }

        static void Square(ref List<Shape> shapes)
        {
            Console.WriteLine("Enter name and side length seperated by space: ");
            string[] temp = Console.ReadLine().Split(' ');
            string name = temp[0];
            decimal side = Convert.ToDecimal(temp[1]);
            shapes.Add(new Square(name, side));
        }

        static void Display(ref List<Shape> shapes)
        {
            if (shapes.Count > 0)
            {
                foreach (var shape in shapes)
                    Console.WriteLine(shape);
            }
            else
                Console.WriteLine("List is empty");
        }
    }
}

