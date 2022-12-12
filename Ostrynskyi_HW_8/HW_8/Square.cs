using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ostrynskyi_HW_8
{
    public class Square : Shape
    {
        private double side;

        public double Side { get { return side; } }

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return (side * side);
        }
        public override double Perimeter()
        {
            return 4 * side;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}, Area: {Area()}, Perimetr: {Perimeter()}");
        }
    }
}
