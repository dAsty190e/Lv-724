using System;

namespace HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("You are working with the person #{0}", i);
                people[i] = new Person();
                people[i].Menu();
            }

            Console.WriteLine("Helluva lot of text incoming!");

            TimeSpan sixteenYears = new TimeSpan(140160, 0, 0);

            foreach (Person person in people)
            {
                Console.WriteLine(person);
                if (person.Age() < sixteenYears)
                {
                    person.ChangeName("Very young");
                }
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            for (int i = 0; i < people.Length - 1; i++)
            {
                if (people[i].Name == people[i + 1].Name)
                {
                    Console.WriteLine("{0} and {1} share a similar name.", people[i], people[i + 1]);
                }
            }
        }
    }
}
