using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class Device : IStatusOnOff
    {
        public string Name { get; set; }
        public bool State { get; set; }
        //abstract public string ToString();
        public void StatusOn()
        {
            State = true;
        }
        public void StatusOff()
        {
            State = false;
        }
    }
}
