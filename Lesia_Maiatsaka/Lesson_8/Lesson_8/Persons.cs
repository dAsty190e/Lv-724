using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    public class Persons
    {
        private string _name;

        public Persons(string name) 
        {
           this._name = name;
        }

        public string Name { get { return _name; } }

        public virtual void Print()
        {
            Console.WriteLine("from persons");
        }
    }
}
