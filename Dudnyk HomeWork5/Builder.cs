using System;
namespace HomeWork5
{
    public class Builder : IDeveloper, IComparable
    {
        string tool;

        public string Tool
        {
            get
            {
                return tool;
            }
            set
            {
                tool = value;
            }
        }

        public void Create()
        {
            Console.WriteLine("Builder can build something with: " + tool);
        }

        public void Destroy()
        {
            Console.WriteLine("Builder can destroy something with the " + tool);
        }

        public int CompareTo(object o)
        {
            Programer p = o as Programer;
            Builder b = o as Builder;
            if (p != null)
                return this.Tool.CompareTo(p.Tool);
            else if (b != null)
                return this.Tool.CompareTo(b.Tool);
            else
                throw new ArgumentException("Object is not a developer");

        }

        public Builder()
        {
            tool = "Hammer";
        }

        public Builder(string s)
        {
            tool = s;
        }

        public override string ToString()
        {
            return this.Tool;
        }
    }
}

