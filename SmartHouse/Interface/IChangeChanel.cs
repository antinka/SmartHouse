using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IChangeChanel
    {
        void NextChannel();
        void PrevChannel();
    }
}
