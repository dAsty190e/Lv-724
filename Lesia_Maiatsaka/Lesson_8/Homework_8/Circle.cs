namespace Homework_8
{
    public class Circle : Shape
    {
        private int _radius;

        public Circle(string name, int radius) : base(name)
        {
            _radius = radius;
        }

        public override double Area()
        {
            base.Area1 = Math.PI * _radius * _radius;
            Console.WriteLine($"Area of circle is: {base.Area1}");
            return base.Area1;
        }

        public override decimal Perimeter()
        {
            base.Perimeter1 = (decimal)(2 * Math.PI * _radius);
            Console.WriteLine($"Perimeter of circle is : {base.Perimeter1}");
            return base.Perimeter1;
        }
    }
}
