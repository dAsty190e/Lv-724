using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ostapchuk_HW_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In the method Main() create 6 objects of Person type and enter information about them. 
            
            //Cbject of class by ParameterLess constructor
            Person person = new Person();
            person.PersonAge();
            //person.Output();

            
            //Object of class by constructor with parameter
            Person person2 = new Person("Person 2", 2001);
            person2.PersonAge();
            //person2.Output();
            Console.WriteLine("---------------------\n");

            //Create Array with object Person
            Person[] personsArray = new Person[4];

            //Fill Array with obect of person class
            for (int i = 2; i < personsArray.Length; i++)
            {
                personsArray[0] = person;
                personsArray[1] = person2;
                personsArray[i] = Person.Input(i);

            }
            Console.WriteLine("------------------------\n");

            //Then calculate and output on the console name and Age of each person;
            for (int i = 0; i < personsArray.Length; i++)
            {

                personsArray[i].PersonAge();
            }
            Console.WriteLine("--------------------\n");

            //Change the name of persons, which Age is less then 16, to "Very Young".

            int ageLimit = 16;
            string newName = "Not to Old";
            Console.WriteLine($"Let`s change Person name to {newName} if age is less than {ageLimit}: ");
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < personsArray.Length; i++)
            {
                if (personsArray[i].Age < ageLimit)
                {
                    string oldName = personsArray[i].Name; ;
                    personsArray[i].ChangeName(newName);
                    Console.WriteLine($"Person with name {oldName} is {personsArray[i]} years old. Name is changed to {personsArray[i].Name} because current age is less than {ageLimit}");
                }
                else
                {
                    Console.WriteLine($"Person with name {personsArray[i].Name} is {personsArray[i].Age} years old. Name wasn`t changed");
                }

            }
            Console.WriteLine("---------------------------\n");

            //Compare Persons classes by the name and age
            
            for (int i = 0; i < personsArray.Length; i++)
            {
                for (int j = i + 1; j < personsArray.Length; j++)
                {
                    if (personsArray[i] == personsArray[j])
                    {
                        Console.WriteLine($"Person {i} are EQUAL to {j}"); //personsArray[i] personsArray[j]
                    }
                    else
                    {
                        Console.WriteLine($"Person {i} are NOT equal to {j}"); //personsArray[i] personsArray[j]
                    }
                }

            }



            Console.ReadLine();

        }

        
    }
}
