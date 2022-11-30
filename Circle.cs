using System;
using System.Reflection.Metadata;

namespace Homework8
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
    }
}

