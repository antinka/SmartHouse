using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Conditioner : Device, ITemperature
    {
        public ModeOfSustemWork mode;
        private int temperature;
        public Conditioner(string name)
        {
            Name = name;
          //  State = false;
            temperature = 0;
        }
        public virtual void TemperaturePlus()
        {
            if (temperature >= -5 && temperature < 30 && State == true)
            {
                temperature += 1;
            }
        }
        public virtual void TemperatureMinus()
        {
            if (temperature > -5 && temperature <= 30 && State == true)
            {
                temperature -= 1;
            }
        }
        /*public void StatusOn()
        {
            State = true;
        }
        public void StatusOff()
        {
            State = false;
        }*/
        public virtual int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value >= -5 && value <= 30)
                    temperature = value;
            }
        }
        public void SetSuperFrost()
        {
            mode = ModeOfSustemWork.SuperFrost;
        }
        public void SetSuperСoold()
        {
            mode = ModeOfSustemWork.SuperСoold;
        }
        public void SetFrostSafe()
        {
            mode = ModeOfSustemWork.FrostSafe;
        }
        public override string ToString()
        {
            string mode;
            string state;
            if (this.mode == ModeOfSustemWork.SuperFrost || temperature <= 0)
            {
                mode = "Супер холод";
            }
            else if (this.mode == ModeOfSustemWork.SuperСoold || (temperature <= 20 && temperature > 0))
            {
                mode = "Холод";
            }
            else
            {
                mode = "Нормальный";
            }
            if (State == false)
            {
                mode = "выключен кондиционер";
                state = "Выключен";
            }
            else
            {
                state = "Включен";
            }

            return "Кондиционер: " + Name + " - Состояние: " + state + " температура  " + temperature + ", режим работы: " + mode;
        }
    }
}
