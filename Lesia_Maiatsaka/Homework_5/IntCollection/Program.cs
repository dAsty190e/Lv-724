namespace IntCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Give me 10 numbers");

            for (int i = 0; i < 10; i++)
            {
                var userInput = int.Parse(Console.ReadLine());
                list.Add(userInput);
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == -10) 
                {
                    Console.WriteLine($"Index of negative 10: {i}");
                }
            }

            var removeList = new List<int>();
            foreach (int i in list) 
            {
                if (i > 20)
                {
                }
                else
                {
                    removeList.Add(i);
                }
            }

            foreach (int i in removeList) 
            {
                Console.WriteLine(i);
            }

            removeList[2] = 1;
            removeList[8] = -3;
            removeList[5] = -4;

            removeList.Sort();

            foreach (int i in removeList)
            {
                Console.WriteLine(i);
            }


        }
    }
}