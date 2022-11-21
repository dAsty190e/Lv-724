namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ufo = new List<IFlyable>();
            ufo.Add(new Bird("King Penguin", false));
            ufo.Add(new Bird("Amazon Parrot", true));
            ufo.Add(new Bird("American Crow", true));
            ufo.Add(new Plane("Beechcraft Baron", 123));
            ufo.Add(new Plane("Gulfstream G450", 654));
            ufo.Add(new Plane("Boing", 999));

            foreach (var flyableObjects in ufo)
            {
                Console.WriteLine(flyableObjects.Fly());
            }
        }
    }
}