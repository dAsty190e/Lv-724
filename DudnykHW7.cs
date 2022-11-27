using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace HomeWork7
{
    class Program
    {
        static void Main()
        {
            var path = @"/Users/aleksandr/Desktop/SoftServe/HW7/Phonebook.txt";


            var phonebook = new Dictionary<string, string>();
            var sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                string name = sr.ReadLine();
                string phone = sr.ReadLine();
                phonebook.Add(name, validate(phone));
            }

            Console.WriteLine("Enter the contact you wish to call: ");
            string contactName = Console.ReadLine();
            try
            {
                Console.WriteLine("Calling {0}", phonebook[contactName]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
            }

            var sw = new StreamWriter(@"/Users/aleksandr/Desktop/SoftServe/HW7/ImprovedPhonebook.txt");

            foreach (var pair in phonebook)
            {
                sw.WriteLine($"{pair.Key}, {pair.Value}");
            }

            sr.Close();
            sw.Close();


            Console.ReadKey(); 
        }

        static string validate(string phone)
        {
            if (phone[0] == '3')
                phone = "+" + phone;
            if (phone[0] == '8')
                phone = "+3" + phone;
            if (phone[0] == '0')
                phone = "+38" + phone;

            return phone;
        }
    }
}

