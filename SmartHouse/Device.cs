using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class Device
    {
        public string Name { get; set; }
        public bool State { get; set; }
        abstract public string Information();
    }
}
