using System;
namespace Task5
{
    public class Bird : IFlyable
    {
        string name;
        bool canFly;
        public void Fly()
        {
            Console.WriteLine($"The {name}, can it fly? {canFly}");
        }

        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }
    }
}

