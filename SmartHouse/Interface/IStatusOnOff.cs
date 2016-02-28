using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IStatusOnOff
    {
        void StatusOn();
        void StatusOff();
    }
}
