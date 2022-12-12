using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_HW_5
{
    internal interface IDeveloper : IComparable<IDeveloper>
    {
        void Create();
        void Destroy();

              
        public string Tool
        {
            get; set;
        }


    }
}
