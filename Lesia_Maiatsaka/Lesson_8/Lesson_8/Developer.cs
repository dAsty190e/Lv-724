using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    public class Developer : Staff
    {
        private string _level;

        public Developer(string name, string level, int salary) : base(name, salary)
        {
            _level = level;
        }

        public override void Print()
        {
            Console.WriteLine($"from developer {base.Name} - {_level}");
        }
    }
}
