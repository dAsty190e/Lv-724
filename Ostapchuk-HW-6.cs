using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = ReadNumber("", "", "");

            int counter = 0;
            int timesToRepeat = 3;
            do
            {
                
                ERROR1:
                Console.WriteLine($"Enter next number bigger than {number}");
                /*string a = Console.ReadLine();
                int nextNumber = CheckIfInt($"enter a numberrrrr", a);*/  //Скористатися методом CheckIfInt ?????

                int nextNumber = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (nextNumber < number)
                    {
                        throw new Exception($"Entered number must be greater than previous. Repeat Input");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Input Error: {ex.Message}");
                    goto ERROR1;
                   
                    //throw;
                }

                counter = counter + 1; //counter ++
                int oldNumber = number;
                number = nextNumber;
                Console.WriteLine($"Number of input is: {counter}. Previous number is: {oldNumber} New number is: {number}");
                

            } while (counter < timesToRepeat);

            Console.WriteLine("Finished");

            Console.ReadKey();

        }

        public static int ReadNumber(string min, string max, string number)
        {
            input:
            int fromNumber = CheckIfInt("Enter integer Min Number: ", min);
            int toNumber = CheckIfInt("Enter integer Max Number: ", max);
            Console.WriteLine($"You definded a Range of numbers [{fromNumber};{toNumber}]");
            Console.WriteLine("--------------------------\n");
            
            try
            {
                if (fromNumber > toNumber || fromNumber == toNumber)
                {
                    throw new ApplicationException("First input number MUST be less than second");
                    //return;
                }
            }
            catch (ApplicationException inputsCompare)
            {
                Console.WriteLine($"Input Error: {inputsCompare.Message}");
                Console.WriteLine("Plese, repeate input");

                goto input;
                //throw;
            }
            finally
            {
                Console.WriteLine("Life is GOOD!");
                Console.WriteLine("--------------------------\n");
            }

            chooseNumber:
            int numberFromRange = CheckIfInt("Enter number from a range: ", number);

            try
            {
                if ((numberFromRange < fromNumber) || (numberFromRange > toNumber))
                {
                    throw new Exception("Number is not in Range");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Input Error: {ex.Message}");
                goto chooseNumber;
                //throw;
            }

            return numberFromRange;




        }

        public static int CheckIfInt(string prompt,string input)
        {
            input:
            try
            {
                Console.Write(prompt);
                bool isNumber = int.TryParse(Console.ReadLine(), out int result);
                if (!isNumber)
                {
                    throw new FormatException("Please input only numbers");
                }
                return result;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input Error: {ex.Message}");
                goto input;
                //throw;
            }
                       
        }

        
        
    }
}
