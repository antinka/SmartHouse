using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Jalousie : Lamp, IStatusOpenClose
    {
       // private BrightnessLevel brightness;
        private bool jalousieState;
        public Jalousie(string name)
            : base(name)
        {
            Name = name;
            State = false;
        }
        public void StatusOpen()
        {
            jalousieState = true;
        }
        public void StatusClose()
        {
            jalousieState = false;
        }
        public override string Information()
        {
            string state;
            string mode;

            if (this.brightness == BrightnessLevel.Low)
            {
                mode = "слабая";
            }
            else if (this.brightness == BrightnessLevel.Medium)
            {
                mode = "средняя";
            }
            else
            {
                mode = "высокая";
            }
            if (jalousieState)
            {
                state = "Открыты";
            }
            else
            {
                state = "Закрыты";
                mode = "0";
            }

            return "Жалюзи: " + Name + " Состояние: " + state + ", яркость света из окна: " + mode;
        }
    }
}
