using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFirstTask
{
    public class Circle : Shape
    {
        private int _radius;

        public Circle(string name, int radius) : base(name, radius)
        {
            _radius = radius;
            base.Area1 = Math.PI * _radius * _radius;
            base.Perimeter1 = (decimal)(2 * Math.PI * _radius);
        }


        public override void Area()
        {
            Console.WriteLine($"Area of circle is: {base.Area1}");
        }

        public override void Perimeter()
        {
            Console.WriteLine($"Perimeter of circle is : {base.Perimeter1}");
        }

    }
}
