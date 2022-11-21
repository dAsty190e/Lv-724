namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> dictionary = new Dictionary<uint, string>();
            dictionary.Add(123, "Lucy"); 
            dictionary.Add(321, "Mark"); 
            dictionary.Add(456, "John"); 
            dictionary.Add(654, "Christine");
            dictionary.Add(789, "Mike");
            dictionary.Add(987, "Lily");
            dictionary.Add(019, "Alex");

            foreach (KeyValuePair<uint, string> item in dictionary)
            {
                Console.WriteLine($"{item.Key} ");
            }

            Console.WriteLine("What key do you want?");
            var userInput = Convert.ToUInt32(Console.ReadLine());
            if (dictionary.ContainsKey(userInput)) 
            {
                Console.WriteLine(dictionary[userInput]);
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }
    }
}