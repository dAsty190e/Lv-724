using System;
namespace Polymorphism
{
    public class Teacher : Staff
    {
        protected string subject;

        public override string Name { get => "Teacher " + base.Name; set => base.Name = value; }
        public string Subject { get => this.subject; }

        public Teacher(string name, int salary, string subject) : base(name, salary)
        {
            this.subject = subject;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Main subject {subject}");
        }
    }
}

