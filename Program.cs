
﻿using System;
using System.Collections.Generic;
using System.Linq;



namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(new Point(1, 2), new Point(5, 5), new Point(5, 2));
            Triangle triangle2 = new Triangle(new Point(3, 2), new Point(5, 4), new Point(8, 2));
            Triangle triangle3 = new Triangle(new Point(3, 4), new Point(0, 0), new Point(2, 2));
            Triangle triangle4 = new Triangle(new Point(1, 8), new Point(8, 3), new Point(4, 5));
            Triangle triangle5 = new Triangle(new Point(3, 6), new Point(3, 5), new Point(5, 0));

            List < Triangle > triangles = new List<Triangle>();
            triangles.Add(triangle1);
            triangles.Add(triangle2);
            triangles.Add(triangle3);
            triangles.Add(triangle4);
            triangles.Add(triangle5);

            var closestToOrigin = triangles.OrderBy(l => l.MinDistanceToOrigin()).FirstOrDefault();

            

            Console.WriteLine("Perimeter is: {0}", triangle1.Perimeter());
            Console.WriteLine(closestToOrigin);

            Console.ReadKey();
            
            bool control;
            do
            {
                Console.WriteLine("Give me two int numb:");
                Console.WriteLine("First number:");
                var userInput = int.Parse(Console.ReadLine());
                Console.WriteLine("Second number:");
                var userInput2 = int.Parse(Console.ReadLine());

                var numbers = new Hw_Math();
                try
                {
                    var result = numbers.Div(userInput, userInput2);
                    control = false;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Cant be divided by 0");
                    Console.WriteLine(ex);
                    Console.WriteLine("Try again");
                    control = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong, try again");
                    throw;
                }
            } while (control);

        }
    }

    public struct Point
    {
        public int x;
        public int y;

        public Point (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x: {x}, y: {y}\n";
        }
    }

    public class Triangle
    {
        public Point coordinate1;
        public Point coordinate2;
        public Point coordinate3;

        public Triangle(Point coordinate1, Point coordinate2, Point coordinate3)
        {
            this.coordinate1 = coordinate1;
            this.coordinate2 = coordinate2;
            this.coordinate3 = coordinate3;
        }

        public double DistanceBetween1and2()
        {
            return Math.Sqrt(Math.Pow(coordinate1.x - coordinate2.x, 2) + Math.Pow(coordinate1.y - coordinate2.y, 2));
        }

        public double DistanceBetween1and3()
        {
            return Math.Sqrt(Math.Pow(coordinate1.x - coordinate3.x, 2) + Math.Pow(coordinate1.y - coordinate3.y, 2));

        }

        public double DistanceBetween2and3()
        {
            return Math.Sqrt(Math.Pow(coordinate2.x - coordinate3.x, 2) + Math.Pow(coordinate2.y - coordinate3.y, 2));

        }

        public double Perimeter()
        {
            return DistanceBetween1and2() + DistanceBetween1and3() + DistanceBetween2and3();
        }

        public double MinDistanceToOrigin()
        {
            List<double> distancesToOrigin = new List<double>();
            distancesToOrigin.Add(Math.Sqrt(Math.Pow(0 - coordinate1.x, 2) + Math.Pow(0 - coordinate1.y, 2)));
            distancesToOrigin.Add(Math.Sqrt(Math.Pow(0 - coordinate2.x, 2) + Math.Pow(0 - coordinate2.y, 2)));
            distancesToOrigin.Add(Math.Sqrt(Math.Pow(0 - coordinate3.x, 2) + Math.Pow(0 - coordinate3.y, 2)));

            var minDistance = distancesToOrigin.OrderBy(l => l).FirstOrDefault();
            return minDistance;
        }


        public override string ToString()
        {
            return $"{coordinate1.ToString()}{coordinate2.ToString()}{coordinate3.ToString()}";
        }

    }

}



