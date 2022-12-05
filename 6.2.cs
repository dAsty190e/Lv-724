using System;

namespace HM6._2.Dima
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two double numbers");
                Console.Write("number1 is ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("number2 is ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (num1 > num2)
                {
                    throw new Exception("number2 must be > number1");
                }
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                Console.WriteLine("{0} / {1} = {2}", num2, num1, num2/num1);
            }
            catch (FormatException exeption)
            {
                Console.WriteLine(exeption.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
