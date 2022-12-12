using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_task_8
{
    public class Teacher : Staff, IComparable<Persons>
    {
        private string subject;

        public Teacher(string name, string subject, int salary) : base(name, salary)
        {
            this.subject = subject;
        }
        public override void Print()
        {
            Console.WriteLine("{0} is a teacher of {1} with salary {2}", Name, subject, Salary);
        }
       
    }
}
