using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    public class Teacher : Staff
    {
        private string _subject;

        public Teacher(string name, string subject, int salary) : base(name, salary)
        {
            _subject = subject;
        }


        public override void Print()
        {
            Console.WriteLine($"from teacher {base.Name} - {_subject}");
        }
    }
}
