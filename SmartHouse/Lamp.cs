using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Lamp : Device,  IBrightness
    {
        public BrightnessLevel brightness;
        public Lamp(string name)
        {
            Name = name;
          //  State = false;
        }
      /*  public void StatusOn()
        {
            State = true;
        }
        public void StatusOff()
        {
            State = false;
        }*/
        public void SetLow()
        {
            brightness = BrightnessLevel.Low;
        }
        public void SetMedium()
        {
            brightness = BrightnessLevel.Medium;
        }
        public void SetHigh()
        {
            brightness = BrightnessLevel.High;
        }
        public override string ToString()
        {
            string state;
            string mode = "";
            if (this.brightness == BrightnessLevel.Low)
            {
                mode = "слабая";
            }
            else if (this.brightness == BrightnessLevel.Medium)
            {
                mode = "средняя";
            }
            else if (this.brightness == BrightnessLevel.High)
            {
                mode = "высокая";
            }
            if (State == false)
            {
                state = "выключен";
                mode = "0";
            }
            else
            {
                state = "включен";
            }

            return "Лампочка: " + Name + " Состояние: " + state + ", яркость: " + mode;
        }
    }
}
