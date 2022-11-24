using System;
using System.Collections.Generic;
using System.Text;

namespace Seletskiy_HW5
{
    interface IDeveloper : IComparable<IDeveloper>
    {
        public string Tool
        {
            get
            {
                return Tool;
            }
        }

        public string Profession
        {
            get
            {
                return Profession;
            }
        }

        public void Create();

        public void Destroy();
    }
}
