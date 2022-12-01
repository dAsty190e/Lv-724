using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostapchuk_HW_5
{
    internal class Program
    {
        internal interface IDeveloper : IComparable
        {
            //Create interface IDeveloper with property Tool, methods Create() and Destroy()

            string Tool { get; set; }
            void Create();
            void Destroy();


        }
        internal class Programmer : IDeveloper, IComparable
        {
            private string language;

            public string Tool
            {
                get { return language; }
                set { language = value; }
            }
            public Programmer(string tool)
            {
                language = tool;
            }

            public void Destroy()
            {
                Console.WriteLine($"Destroy method work from Programmer by {Tool} ");
            }

            public void Create()
            {
                Console.WriteLine($"Create method work from Programmer by {Tool} ");
            }


            public int CompareTo(object o)
            {
                Programmer programmer = o as Programmer;
                Builder builder = o as Builder;
                if (programmer != null)
                {
                    return this.Tool.CompareTo(programmer.Tool);
                }
                else if (builder != null)
                {
                    return this.Tool.CompareTo(builder.Tool);
                }
                else
                    throw new ArgumentException("Object is not a developer");
            }


        }

        internal class Builder : IDeveloper, IComparable
        {
            private string tool;

            public string Tool
            {
                get { return tool; }
                set { tool = value; }
            }

            public Builder(string tool)
            {
                this.tool = tool;
            }



            public void Create()
            {
                Console.WriteLine($"Create method work from Builder by {Tool} ");
            }

            public void Destroy()
            {
                Console.WriteLine($"Destroy method work from Builder by {Tool} ");
            }

            public int CompareTo(object o)
            {
                Builder builder = o as Builder;
                Programmer programmer = o as Programmer;

                if (builder != null)
                {
                    return this.Tool.CompareTo(builder.Tool);
                }
                else if (programmer != null)
                {
                    return this.Tool.CompareTo(programmer.Tool);
                }
                else
                    throw new ArgumentException("Object is not a builder");
            }

        }

        static void Main(string[] args)
        {
            List<IDeveloper> list = new List<IDeveloper>();
            list.Add(new Builder("Hummer"));
            list.Add(new Builder("Hummer2"));
            list.Add(new Builder("Wrench"));
            list.Add(new Programmer("C#"));
            list.Add(new Programmer("C#2"));
            list.Add(new Programmer("JavaScript"));

            
            foreach (IDeveloper i in list)
            {
                i.Create();
                i.Destroy();
            }

            list.Sort();

            foreach (IDeveloper i in list)
            {
                Console.WriteLine(i.Tool);
            }




            Console.ReadKey();
        }
    }
}
