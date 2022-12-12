using System;
using System.Linq;

namespace Seletskiy_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            void calculateLetters()
            {
                Console.WriteLine("Enter your string:");
                string userInput = (Console.ReadLine()).ToLower();
                int letterA = 0;
                int letterO = 0;
                int letterI = 0;
                int letterE = 0;

                foreach (char ch in userInput)
                {
                    switch (ch)
                    {
                        case 'a':
                            letterA++;
                            break;

                        case 'o':
                            letterO++;
                            break;

                        case 'i':
                            letterI++;
                            break;

                        case 'e':
                            letterE++;
                            break;
                    }
                }

                Console.WriteLine("There are {0} letter(s) 'A', {1} letter(s) O, {2} letter(s) I and {3} letter(s) E in your string", letterA, letterO, letterI, letterE);
            }

            void daysInMonth()
            {
                Console.WriteLine("Please enter the number of the month:");

                int monthNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(DateTime.DaysInMonth(2002, monthNumber));

            }

            void arrayCounter()
            {
                Console.WriteLine("Enter 10 numbers below:");
                int[] userInput = new int[10];
                int sum = 0;
                int product = 0;
                bool returnSum = true;

                for (int i = 0; i < 10; i++)
                {
                    userInput[i] = Convert.ToInt32(Console.ReadLine());

                    if (i <= 4)
                    {
                        if(userInput[i] < 0)
                        {
                            sum = 0;
                            i = 4;
                            product = 1;
                            returnSum = false;
                        }
                        else
                        {
                            sum += userInput[i];
                        }
                    }

                    if (i > 4)
                    {
                        product *= userInput[i];
                    }
                }

                Console.WriteLine(returnSum ? sum :  product);

            }

            //calculateLetters();
            //daysInMonth();
            arrayCounter();
        }
    }
}
