using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*namespace SmartHouse
{
    public class Fridge : Device, IStatusOnOff, ITemperature, IStatusOpenClose
    {

        private ModeOfSustemWork mode;
        private bool doorState;
        private int temperature;
        public Fridge(string name)
        {
            Name = name;
            State = false;
        }
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value >= -20 && value <= 20)
                    temperature = value;
            }
        }
        public void StatusOn()
        {
            State = true;
        }

        public void StatusOff()
        {
            State = false;
        }

        public void StatusOpen()
        {
            doorState = true;
        }

        public void StatusClose()
        {
            doorState = false;
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
        public override string Information()
        {
            string mode;
            string state;
            string doorState;

            if (this.mode == ModeOfSustemWork.SuperFrost)
            {
                mode = "Супер заморозка";
            }
            else if (this.mode == ModeOfSustemWork.SuperСoold)
            {
                mode = "Супер холод";
            }
            else
            {
                mode = "Нормальный";
            }

            if (State == false)
            {
                mode = "выключен холодильник";
                state = "Выключен";
            }
            else
            {
                state = "Включен";
            }
            if (this.doorState == true)
            {
                doorState = "лучше закрыть дверцу холодильника";
            }
            else
            {
                doorState = "дверца холодильника закрыта";
            }

            return "Холодильник: " + Name + " - Состояние: " + state + "температура в холодильнике " + temperature + ", режим работы: " + mode + ", " + doorState;
        }
    }
}*/
namespace SmartHouse
{
    public class Fridge : Conditioner, IStatusOpenClose
    {
        //private ModeOfSustemWork mode;
        private bool doorState;
        private int temperature;
        public Fridge(string name): base(name)
        {
            Name = name;
            State = false;
        }
        public override void TemperaturePlus()
        {
            if (temperature >= -20 && temperature < 10 && State == true)
            {
                temperature += 1;
            }
        }
        public override void TemperatureMinus()
        {
            if (temperature > -20 && temperature <= 10 && State == true)
            {
                temperature -= 1;
            }
        }
        public override int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value >= -20 && value <= 10)
                    temperature = value;
            }
        }
        public void StatusOpen()
        {
            doorState = true;
        }
        public void StatusClose()
        {
            doorState = false;
        }
        public override string Information()
        {
            string mode;
            string state;
            string doorState;
            if (this.mode == ModeOfSustemWork.SuperFrost)
            {
                mode = "Супер заморозка";
            }
            else if (this.mode == ModeOfSustemWork.SuperСoold)
            {
                mode = "Супер холод";
            }
            else
            {
                mode = "Нормальный";
            }
            if (State == false)
            {
                mode = "выключен ";
                state = "Выключен";
            }
            else
            {
                state = "Включен";
            }
            if (this.doorState == true)
            {
                doorState = "лучше закрыть дверцу";
            }
            else
            {
                doorState = "дверца закрыта";
            }

            return "Холодильник: " + Name + " Состояние: " + state + " температура " + temperature + ", режим работы: " + mode + ", " + doorState;
        }

       
    }
}
