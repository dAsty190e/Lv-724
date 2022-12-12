
namespace PointAndTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point _p1, _p2, _p3;
            _p1 = new Point(1, 5);
            _p2 = new Point(4, 1);
            _p3 = new Point(1, 1);
            Triangle triangle1 = new Triangle(_p1, _p2, _p3);

            Console.ReadKey();
        }
    }
}