using System;
namespace Homework8
{
    public class Square : Shape
    {
   
        private readonly decimal perimeter;

        public decimal GetArea { get { return area; } }

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

    }
}

