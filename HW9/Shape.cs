using System;
namespace Homework9
{
    public abstract class Shape : IComparable
    {
        string name;
        public decimal area;
        
        public string Name { get { return this.name; } set { this.name = value; } }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract decimal Perimeter(decimal side);
        public abstract decimal Area(decimal side);

        public override string ToString()
        {
            return $"Shape: {name}\nArea: {area}";
        }

        public int CompareTo(object obj)
        {
            if (obj != null)
            {
                Shape c = obj as Shape;
                if (c != null)
                {
                    return this.area.CompareTo(c.area);
                }
                else
                    throw new ArgumentException("Not a Shape");
            }
            else
                return 1;
        }

        
    }
}

