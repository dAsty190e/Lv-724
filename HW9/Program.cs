using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homework9
{
    class Program
    {
        static void Main()
        {
            // A
            List<Square> squares = Square.GetSqueres();
            List<Circle> circles = Circle.GetCircles();

            List<Shape> shapes = new List<Shape>();
            shapes.AddRange(squares);
            shapes.AddRange(circles);

            string path = @"/Users/aleksandr/Desktop/SoftServe/HW9/Homework9/Shapes.txt";
            string path1 = @"/Users/aleksandr/Desktop/SoftServe/HW9/Homework9/Letter.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                var values = shapes.Where(l => l.area > 10 && l.area < 100);
                foreach (var value in values)
                    sw.WriteLine(value.ToString());
            }

            using (var sw = new StreamWriter(path1))
            {
                var values = shapes.Where(l => l.Name.Contains('a'));
                foreach (var value in values)
                    sw.WriteLine(value.ToString());
            }

            
            var perimeters =  squares.Where(l => l.GetPerimeter < 25);
            var circlePerimeters = circles.Where(l => l.GetPerimeter < 25).ToList();

            List<Shape> shapes1 = new List<Shape>();
            shapes1.AddRange(perimeters);
            shapes1.AddRange(circlePerimeters);

            foreach (var per in shapes1)
                Console.WriteLine(per.ToString());




            // B
            List<string> strings = new List<string>();
            path = @"/Users/aleksandr/Desktop/SoftServe/HW9/Homework9/program.txt";
            using (StreamReader sr = new StreamReader(path))
            { 
                while (!sr.EndOfStream)
                {
                    strings.Add(sr.ReadLine());
                }
            }

            int k = 1;
            foreach (var line in strings)
            {
               
                Console.WriteLine("Character count for {0} line is: {1}", k, line.Count());
                k++;
            }

            string minString = null;
            int i = 1;
            for ( ; i < strings.Count; i++)
            {
                minString = strings[0];
                if (minString.Count() > strings[i].Count())
                {
                    minString = strings[i];
                }
            }

            Console.WriteLine("Min string is: {0} ", minString);

            string maxString = strings[0];
            int j = 1;
            for (; j < strings.Count; j++)
            {

                if (maxString.Count() < strings[j].Count())
                {
                    maxString = strings[j];
                    
                }
            }
            Console.WriteLine("Max string is: {0}", maxString);

            var symbols = from s in strings
                          select s.Count();

            foreach (var s in symbols)
                Console.Write(s + " ");

            var Varword = from s in strings
                          where s.Contains("var")
                          select s;

            foreach (var s in Varword)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}

