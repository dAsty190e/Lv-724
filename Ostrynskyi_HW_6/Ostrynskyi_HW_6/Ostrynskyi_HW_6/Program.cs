using Ostrynskyi_HW_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_HW_6
{
    class Program : Exception
    {
        static void Main(string[] args)
        {
            int[] range = new int[2];
            int[] numbers = new int[10];

        again1:
            try
            {
                Console.Write("Please, enter the start number: ");
                range[0] = Int32.Parse(Console.ReadLine());
                Console.Write("Please, enter the end number:");
                range[1] = Int32.Parse(Console.ReadLine());
                if (range[0] == range[1] || range[0] > range[1])
                { throw new ArgumentException("Please, try again, your numbers are equal or start num is less than end"); }
                if (range[1] - range[0] < 10) throw new EndNumberException("");
                
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                goto again1;
            }
            catch (EndNumberException exception)
            {
                Console.WriteLine(exception.Message);
                goto again1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto again1;
            }

        again2:
            for (int i = 0; i < 10;)
            {
                try
                {
                    Console.WriteLine($"Enter integer # {i + 1} in range from {range[0]} to {range[1] - 1} (inclusive)");
                    int number = Int32.Parse(Console.ReadLine());
                    if (number >= range[0] && number <= (range[1] - 1))
                    {
                        range[0] = number + 1;
                        numbers[i] = number;
                        i++;
                    }
                    else
                    {
                        throw new Exception($"You should enter a number in the range from {range[0]} to {range[1] - 1} (inclusive)");
                        goto again2;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Please, enter correct integer number {e.Message}");
                    goto again2;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    goto again2;
                }
            
            }
        }

    }
}

