using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ostrynskyi_task_8
{
    public class Staff : Persons
    {
        public int Salary;
        public Staff(string name, int salary) : base(name)
        {
            Salary = salary;
        }
        public override void Print()
        {
            Console.WriteLine("{0} is a stuff with salary {1}", Name, Salary);
        }
        
    }
}
