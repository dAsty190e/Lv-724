using Homework_6;

namespace Homework_6_Readnumbers.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new ReadNumbers(10, 100);

            bool control = true;
            do
            {
                Console.WriteLine("Give me a number");
                var userInput = int.Parse(Console.ReadLine());

                try
                {
                    control = !numbers.Complete(userInput);
                    numbers.ReadNumber(userInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (control);
            Console.WriteLine(string.Join(", ", numbers.ValidNumbers));
        }
    }
}