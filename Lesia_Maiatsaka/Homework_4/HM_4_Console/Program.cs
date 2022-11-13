using HM_4_Person;

namespace HM_4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = Engine.PopulatePersons(6);

            // output information
            foreach (var item in people)
            {
                Console.WriteLine(item + $" ({item.BirthDay})");
            }
            Console.WriteLine();

            var uniqueNameCounts = Engine.CreateUniqueNameCountDictionary(people);

            // loop though dictionary 
            foreach (var person in uniqueNameCounts)
            {
                if (person.Value > 1)
                {
                    Console.WriteLine($"{person.Key} occurs {person.Value} times");
                }
            }
        }
    }
}