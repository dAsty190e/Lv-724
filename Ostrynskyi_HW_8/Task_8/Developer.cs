using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ostrynskyi_task_8
{
    public class Developer : Staff, IComparable<Persons>
    {
        private string level;
        public Developer(string name, string level, int salary) : base(name, salary)
        {
            this.level = level;
        }
        public override void Print()
        {
            Console.WriteLine("{0} is a {1} developer with salary {2}", Name, level, Salary);
        }
    }
}