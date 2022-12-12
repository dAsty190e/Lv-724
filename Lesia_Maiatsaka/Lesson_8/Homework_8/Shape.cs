﻿using System.Collections.Generic;

namespace Homework_8
{
    public abstract class Shape 
    {
        private string _name;
        public string Name { get { return _name; } }

        public Shape(string name)
        {
            _name = name;
        }

        public abstract double Area();
        public abstract decimal Perimeter();

        public decimal Perimeter1 { get; set; }
        public double Area1 { get; set; }

    }
}

