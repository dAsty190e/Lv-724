using System;
using System.Collections.Generic;

namespace Homework9
{
    public class Square : Shape
    {

        private readonly decimal perimeter;

        public decimal GetArea { get { return area; } }

        public decimal GetPerimeter { get { return perimeter; } }


        public Square(string name, decimal side) : base(name)
        {
            base.area = Area(side);
            perimeter = Perimeter(side);
        }

        public override decimal Area(decimal side)
        {
            return side * side;
        }

        public override decimal Perimeter(decimal side)
        {
            return side * 4;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPerimeter: {perimeter}";
        }

        // Method that creates a list of squeres, to save time

        static public List<Square> GetSqueres()
        {
            List<Square> output = new List<Square>()
            {
                new Square("Picture", 30),
                new Square("TV-set", 40),
                new Square("Book", 5),
                new Square("Monitor", 32),
                new Square("LapTop", 13),
                new Square("IPad", 10),
                new Square("Table", 50),
                new Square("Door", 60)
            };

            return output;
        }

    }

}
 

