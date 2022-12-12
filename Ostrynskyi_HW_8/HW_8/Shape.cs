﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_HW_8
{
    public abstract class Shape : IComparable<Shape>
    {
        public string name;

        public string Name
        {
            get { return name; }
        }

        public Shape(string name)
        {
            this.name = name;
        }
        
        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            if (other == null) return 1;
            else
                  return this.Area().CompareTo(other.Area());
        }
        public abstract void Print();
    }
}
