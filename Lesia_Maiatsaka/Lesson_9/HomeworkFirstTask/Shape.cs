using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFirstTask
{
    public abstract class Shape
    {
        private string _name;
        private int _size;

        public string Name { get { return _name; } }
        public int Size { get { return _size; } }

        public Shape(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public abstract void Area();
        public abstract void Perimeter();

        public decimal Perimeter1 { get; set; }
        public double Area1 { get; set; }

        public override string ToString()
        {
            return $"- The {_name} has size: {_size} and area: {Area1} and perimeter: {Perimeter1}\n";
        }
    }
}
