namespace PointAndTriangle
{
    public class Point
    {
        public int _x;
        public int _y;

        public Point(int x, int y) { _x = x; _y = y; }
        public int Distance(Point point)
        {
            return (_x + point._x) + (_y + point._y);
        }
    }

    public class Triangle
    {
        private Point _p1, _p2, _p3;
        public Triangle(Point a, Point b, Point c) { _p1 = a; _p2 = b; _p3 = c; }
        public int Perimeter() 
        {
            var T = _p1.Distance(_p2) + _p2.Distance(_p3) + _p3.Distance(_p1);
            return T; 
        }
        public string Print() 
        {
            return $"I hate triangles and points!";
        }
    }
}
