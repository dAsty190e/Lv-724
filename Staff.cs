using System;
namespace Polymorphism
{
    public class Staff : Person, IComparable<Staff>
    {
        protected int salary;
        public int Salary { get => this.salary; }

        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Salary: {0}", salary);
        }

        public int CompareTo(Staff person)
        {
            if (person == null)
                return 1;

            if (this.salary.CompareTo(person.salary) == 1)
                return this.fullName.CompareTo(person.fullName);
            else
                return this.salary.CompareTo(person.salary);
        }
    }
}

