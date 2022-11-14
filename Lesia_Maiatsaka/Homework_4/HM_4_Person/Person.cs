namespace HM_4_Person
{
    public class Person
    {
        private string? _name;
        private DateOnly? _birthDay;

        public string? Name { get { return _name; } }
        public DateOnly? BirthDay { get { return _birthDay; } }

        public Person()
        {

        }

        public Person(string name, DateOnly birthDay)
        {
            _name = name;
            _birthDay = birthDay;
        }

        public int Age() 
        {
            return DateTime.Now.Year - _birthDay?.Year ?? DateTime.Now.Year;
        }

        public void ChangeName(string newName) 
        {
            _name = newName;
        }

        public override string ToString()
        {
            return $"{Name} is {Age()} year{(Age() == 1 ? "" : "s")} old";
        }
    }
}