using HM_4_Person;
using NameGenerator.Generators;

namespace HM_4_Person
{
    public static class Engine
    {
        public static List<Person> PopulatePersons(int total, int minAge = 16, string underAgeName = "Very Young", int maxAge = 80) 
        {
            var random = new Random();
            var randomName = new RealNameGenerator();
            var list = new List<Person>();
            for (int i = 0; i < total; i++)
            {
                var date = DateTime.Now
                            .AddYears(random.Next(0, maxAge) * -1)
                            .AddMonths(random.Next(1, 12));
                date = date.AddDays(random.Next(1, DateTime.DaysInMonth(date.Year, date.Month)));
                var birthDay = DateOnly
                    .FromDateTime(date);

                var person = new Person(randomName.Generate(), birthDay);
                if (person.Age() <= minAge) person.ChangeName(underAgeName);
                list.Add(person);
            }

            return list;
        }

        public static Dictionary<string, int> CreateUniqueNameCountDictionary(List<Person> people) 
        {
            var uniqueName = new Dictionary<string, int>();

            // loop through the names 
            // populate the dictionary
            foreach (var person in people)
            {
                // skip if key already is in dictionary
                if (uniqueName.ContainsKey(person.Name!))
                {
                    continue;
                }

                int count = 0;
                foreach (var item in people)
                {
                    if (person.Name == item.Name)
                    {
                        count++;
                    }
                }
                // add key value to dictionary
                uniqueName.Add(person.Name!, count);
            }

            return uniqueName;
        }
    }
}
