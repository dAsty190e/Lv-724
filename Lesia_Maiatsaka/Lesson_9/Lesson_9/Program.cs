namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfInt = new List<int>();
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Give me a number: ");
                var userInput = int.Parse(Console.ReadLine()!);
                listOfInt.Add(userInput);
            }
            var numberCount = new CountNumbers(listOfInt);

            Console.WriteLine("Negative numbers: " + string.Join(", ", numberCount.GetNegativeNumbers()));
            Console.WriteLine("Positive numbers: " + string.Join(", ", numberCount.GetPositiveNumbers()));
            Console.WriteLine("Largest number: " + numberCount.LargestNumber());
            Console.WriteLine("Smallest number: " + numberCount.SmallestNumber());
            Console.WriteLine("Sum of numbers: " + numberCount.SumOfElements());
            Console.WriteLine("First below average: " + numberCount.FirstBelowAverage());
        }
    }
}