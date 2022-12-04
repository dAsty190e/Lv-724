using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFirstTask
{
    public class Square : Shape
    {
        private int _side;

        public Square(string name, int side) : base(name, side)
        {
            _side = side;
            base.Area1 = _side * _side;
            base.Perimeter1 = 4 * _side;
        }

        public override void Area()
        {
            Console.WriteLine($"Area of square is : {base.Area1}");
        }

        public override void Perimeter()
        {
            Console.WriteLine($"Perimeter of square is : {base.Perimeter1}");
        }

    }
}
