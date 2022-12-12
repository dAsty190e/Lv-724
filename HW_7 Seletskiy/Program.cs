using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Seletskyi_HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();

            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\V\Desktop\С#\1\Seletskiy_Homeworks\Seletskiy_Homeworks\Seletskyi_HW7\Seletskyi_HW7\Phones.txt", false, System.Text.Encoding.Default))
                {
                    string[] crutch = File.ReadAllLines(@"C:\Users\V\Desktop\С#\1\Seletskiy_Homeworks\Seletskiy_Homeworks\Seletskyi_HW7\Seletskyi_HW7\phonesPlusNames.txt");
                    List<string> names = new List<string>();
                    List<string> phones = new List<string>();
                    foreach (string line in crutch)
                    {
                        if (line[0] != '+' && line[0] != '8')
                        {
                            names.Add(line);
                        }
                        else
                        {
                            phones.Add(line);
                            sw.WriteLine(line);
                        }
                    }

                    for (int i = 0; i < names.Count; i++)
                    {
                        PhoneBook.Add(names[i], phones[i]);
                    }

                    foreach (string line in phones)
                    {
                        if (line[0] == '8')
                        {
                            using (StreamWriter newPhoneWriter = new StreamWriter(@"C:\Users\V\Desktop\С#\1\Seletskiy_Homeworks\Seletskiy_Homeworks\Seletskyi_HW7\Seletskyi_HW7\changedPhoneNumbers.txt", false, System.Text.Encoding.Default))
                            {
                                newPhoneWriter.WriteLine("+3" + line);
                            }
                        }
                    }

                    Console.WriteLine("Enter the name of the poor soul whose name will be run through SBU database:");
                    string inputName = Console.ReadLine();
                    Console.WriteLine("Here's their number, give them a call:\n{0}", PhoneBook[inputName]);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("You fucked up, here's why:\n {0}", e.Message);
            }
        }
    }
}
