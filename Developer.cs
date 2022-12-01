using System;
namespace Polymorphism
{
    public class Developer : Staff
    {
        protected string level;

        public override string Name { get => "Programmer " + base.Name; set => base.Name = value; } 

        public string Level { get => this.level; }

        public Developer(string name, int salary, string level) : base(name, salary) 
        {
            this.level = level;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Tech level: {level}");
        }
    }
}

