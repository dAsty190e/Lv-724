using System;
using System.Reflection.Metadata;
using System.Collections.Generic;

namespace Homework9
{
	public class Circle : Shape
	{
        private readonly decimal length;

        public decimal GetArea { get { return area; } }

        public Circle(string name, decimal radius) : base(name)
		{
            base.area = Area(radius);
            length = Perimeter(radius);
		}

        public decimal GetPerimeter { get { return length; } }
		public override decimal Area(decimal radius)
        {
			return (decimal)Math.PI * radius * radius;
        }

        public override decimal Perimeter(decimal radius)
        {
            return 2 * (decimal) Math.PI * radius;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nLength: {length}";
        }

        // Method that creates a list of squeres, to save time
        static public List<Circle> GetCircles()
        {
            List<Circle> circles = new List<Circle>()
            {
                new Circle("Ring", 3),
                new Circle("Plate", 10),
                new Circle("CD", 5),
                new Circle("Halo", 9),
                new Circle("Moon", 100),
                new Circle("Sun", 250)
            };

            return circles;
        }
    }
}

