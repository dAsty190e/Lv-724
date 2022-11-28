using System;

namespace HM5
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer1 = new Programmer("Go");
            Programmer[] programmers = new Programmer[6];
            programmers[0] = programmer1;
            for (int i = 1; i < programmers.Length; i++)
            {
                programmers[i] = Programmer.Input(i);
            }
            for (int i = 0; i < programmers.Length; i++)
            {
                programmers[i].Create();
                programmers[i].Destroy();
            }
            Array.Sort(programmers);
            foreach (Programmer i in programmers)
            {
                Console.WriteLine(i.Tool);
            }
            Builder builder = new Builder("hammer");
            Builder[] builders = new Builder[6];
            builders[0] = builder;
            for (int i = 1; i < programmers.Length; i++)
            {
                builders[i] = Builder.Input(i);
            }
            for (int i = 0; i < builders.Length; i++)
            {
                builders[i].Create();
                builders[i].Destroy();
            }
            Array.Sort(builders);
            foreach (Builder i in builders)
            {
                Console.WriteLine(i.Tool);
            }
        }
    }
}
