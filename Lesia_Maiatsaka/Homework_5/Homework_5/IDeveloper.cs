﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    public interface IDeveloper : IComparable<IDeveloper> 
    {
        public string Tool { get; set; }
        public string Create();
        public string Destroy();

    }
}
