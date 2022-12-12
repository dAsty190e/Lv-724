using System;
namespace Polymorphism
{
    public abstract class Person : IComparable
    {
        protected string fullName;

        public virtual string Name
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
        public Person(string name)
        {
            this.fullName = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Name: {0}", fullName);
        }

        public int CompareTo(object obj)
        {
            if (obj != null)
            {
                Person p = obj as Person;
                if (p != null)
                {
                    return this.fullName.CompareTo(p.fullName);
                }
                else
                    throw new ArgumentException("The object is not a \"Person\"");
            }
            else
                return 1;
        }
    }
}

