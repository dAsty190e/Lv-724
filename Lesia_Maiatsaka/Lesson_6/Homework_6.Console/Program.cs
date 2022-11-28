namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool control;
            do
            {
                Console.WriteLine("Give me two int numb:");
                Console.WriteLine("First number:");
                var userInput = int.Parse(Console.ReadLine());
                Console.WriteLine("Second number:");
                var userInput2 = int.Parse(Console.ReadLine());

                var numbers = new Hw_Math();
                try
                {
                    var result = numbers.Div(userInput, userInput2);
                    control = false;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Cant be divided by 0");
                    Console.WriteLine(ex);
                    Console.WriteLine("Try again");
                    control = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong, try again");
                    throw;
                }
            } while (control);

        }
    }
}