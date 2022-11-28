using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_HW_6
{
    public class EndNumberException : Exception
    {
        public EndNumberException() { }

        public EndNumberException(string name)
            : base(String.Format("The end number should be greater than start for 10 more"))
        {

        }
    }
}
