namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Persons>();

            list.Add(new Teacher("Ann", "English", 463));
            list.Add(new Teacher("Sara", "Math", 321));

            list.Add(new Developer("John", "Junior", 567));
            list.Add(new Developer("Amelia", "Senior", 9999999));

            foreach (var item in list) 
            {
                item.Print();
            }
            Console.WriteLine("|-|-|-|-|-|-|-|");

            var employes = new List<Staff>();

            var newList = list.OrderBy(name => name.Name).ToList();
            foreach (var item in newList)
            {
                if (item is Staff)
                {
                    employes.Add(item as Staff);
                }
                item.Print();
            }
            Console.WriteLine("|-|-|-|-|-|-|-|");

            foreach (var item in employes.OrderBy(salary => salary.Salary))
            {
                Console.WriteLine($"{item.Name} get - {item.Salary}");
            }
        }
    }
}