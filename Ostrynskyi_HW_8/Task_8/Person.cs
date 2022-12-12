using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_task_8
{
    public class Persons : IComparable<Persons>
    {
        private string name;

        public Persons(string name)
        {
            this.name = name;
        }   
        public string Name { get { return name; } }

        public virtual void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }
        int IComparable<Persons>.CompareTo(Persons other)
        {
            return String.Compare(this.Name, other.Name);
        }
    }
}
