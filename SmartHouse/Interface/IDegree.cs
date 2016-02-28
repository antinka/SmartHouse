using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface ITemperature
    {
        int Temperature { get; set; }
        void SetSuperFrost();
        void SetSuperСoold();
        void SetFrostSafe();
        void TemperaturePlus();
        void TemperatureMinus();
    }
}
