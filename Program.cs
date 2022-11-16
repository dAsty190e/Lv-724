using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Output();

            Person person2 = new Person("fjkvfdv", 2002);
            person2.Output();
            Person[] persons = new Person[6];
            persons[0] = person;
            persons[1] = person2;
            for (int i = 2; i < persons.Length; i++)
            {
                persons[i] = Person.Input(i);
            }
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Age();
                persons[i].Output();
            }
            string newName = "Very Young";
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].age < 16)
                {
                    persons[i].Name = newName;
                    Console.WriteLine($"people number {i + 1} has new name - {newName}");
                }
            }
            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"people number {i + 1} and {j + 1}  have the same name");
                    }
                }
            }
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
    }
}
