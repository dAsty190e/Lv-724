namespace Student
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            string userInput;

            var groupA = new GroupInfo
            {
                GroupNumber = 1,
                Students = new StudentInfo[]
                {
                    new StudentInfo
                    {
                        FirstName = "Ann",
                        LastName = "Boleyn",
                    },
                    new StudentInfo
                    {
                        FirstName = "Feret",
                        LastName = "Lama",
                    },
                     new StudentInfo
                    {
                        FirstName = "Piper",
                        LastName = "Cat",
                    },
                    new StudentInfo
                    {
                        FirstName = "Lita",
                        LastName = "Strange",
                    },
                     new StudentInfo
                    {
                        FirstName = "Mana",
                        LastName = "Manula",
                    },
                     new StudentInfo
                    {
                        FirstName = "Maria",
                        LastName = "Catolina",
                    }
                }
            };
            var groupB = new GroupInfo
            {
                GroupNumber = 2,
                Students = new StudentInfo[]
                {
                    new StudentInfo
                    {
                        FirstName = "Naomi",
                        LastName = "Boston",
                    },
                    new StudentInfo
                    {
                        FirstName = "Vinessa",
                        LastName = "Florida",
                    },
                     new StudentInfo
                    {
                        FirstName = "John",
                        LastName = "California",
                    },
                    new StudentInfo
                    {
                        FirstName = "Bastet",
                        LastName = "Piramid",
                    },
                     new StudentInfo
                    {
                        FirstName = "Chapa",
                        LastName = "Madrid",
                    },
                     new StudentInfo
                    {
                        FirstName = "Lola",
                        LastName = "Mandragora",
                    }
                }
            };

            var groups = new GroupInfo[]
            {
                groupA, groupB
            };

            foreach (var groop in groups)
            {
                Console.WriteLine(groop.GroupNumber);

                foreach (var student in groop.Students)
                {
                    Console.WriteLine(student.LastName);
                }
            }

            Console.WriteLine("\nGive me the student group number");
            var userNumber = Console.ReadLine();
            var number = int.Parse(userNumber);

            // .First alternative
            GroupInfo? selectedGroup = null;
            foreach (var grp in groups)
            {
                if (grp.GroupNumber == number)
                {
                    selectedGroup = grp;
                    break;
                }
            }
            // / .First alternative

            if (selectedGroup != null)
            {
                Console.WriteLine($"\nGive me the student first letter of Last name from group {userNumber}");
                var userLetter = Console.ReadKey(true).KeyChar;

                // .Where alternative
                List<StudentInfo> studentInfoMatches = new List<StudentInfo>();
                foreach (var student in selectedGroup.Value.Students)
                {
                    if (student.LastName.ToLower().StartsWith(userLetter))
                    {
                        studentInfoMatches.Add(student);
                    }
                }
                // / .Where alternative

                foreach (var student in studentInfoMatches)
                {
                    Console.WriteLine(student.LastName);
                }

                // .Any alternative
                bool any = false;
                foreach (var student in studentInfoMatches)
                {
                    any = true;
                }

                if (any)
                {
                    Console.WriteLine("There no matches");
                }
                // / .Any alternative

            } 
            else
            {
                Console.WriteLine("bad group number");
            }
        }
    }
}