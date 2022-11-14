using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public struct StudentInfo 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public struct GroupInfo 
    {
        public StudentInfo[] Students { get; set; }
        public int GroupNumber { get; set; }

    }
}
