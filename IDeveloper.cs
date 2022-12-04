using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homework5
{
    public interface IDeveloper : IComparable<IDeveloper>
    {
        public string Tool { get; set; }
        public string Create();
        public string Destroy();
    }
}
