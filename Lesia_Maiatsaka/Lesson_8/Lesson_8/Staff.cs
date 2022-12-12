namespace Lesson_8
{
    public class Staff : Persons
    {
        public int Salary;
        public Staff(string name, int salary) : base(name)
        {
            Salary = salary;
        }
    }
}
