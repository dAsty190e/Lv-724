namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1

            int month;
            int day;

            Console.WriteLine("Give me a month");
            var userInput = Console.ReadLine();
            month = int.Parse(userInput);
            Console.WriteLine("Give me a day");
            userInput = Console.ReadLine();
            day = int.Parse(userInput);
            DateTime.Parse($"{month}/{day}/2022");
            Console.WriteLine("valid");

            // #2

            Console.WriteLine("\nGive me a number with dot. Example: 23.3456");
            double number = Convert.ToDouble(Console.ReadLine());
            var numberAsString = number.ToString();

            var indexOfDot = numberAsString.IndexOf('.');
            var firstIndex = int.Parse(numberAsString[indexOfDot + 1].ToString());
            var secondIndex = int.Parse(numberAsString[indexOfDot + 2].ToString());
            Console.WriteLine(firstIndex + secondIndex);

            // #3

            Console.WriteLine("\nWhat time do you have now?");
            int h = 24;
            var ansver = (h >= 0 && h <= 6) ? "Good morning" :
                (h >= 7 && h <= 12) ? "Good afternoon" :
                (h >= 13 && h <= 18) ? "Hello Hello" :
                "Good night";
            Console.WriteLine(ansver);

            // #4

            var test1Status = TastCaseStatus.Pass;
            Console.WriteLine(test1Status);

            // #5

            var color = new colorRGB();
            Console.WriteLine("\nWhite " + color.SetColor(255, 255, 255) + "\n Black " + color.SetColor(0, 0, 0));
            Console.WriteLine();
        }
    }

    enum TastCaseStatus
    { Pass, Fail, Blocked, WP, Unexecuted };

    struct colorRGB
    {
        public byte r, g, b;
        //public override string ToString() 
        //{
        //    return string.Format("({0},{1},{2})", r, g, b);
        //}
        public string SetColor(byte r, byte g, byte b) 
        { 
            return string.Format("({0},{1},{2})", r, g, b);
        }

    }
}