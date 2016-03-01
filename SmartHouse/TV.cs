using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class TV : Device, IVolume, IChangeChanel
    { 
        private int channel;
        private int volume;
        private int currentChannel;
        public TV(string name)
        {
            Name = name;
          //  State = false;
        }
        public int Chanel
        {
            get
            {
                return channel;
            }
        }
        public void NextChannel()
        {
            if (channel < 99 && State == true)
            {
                channel += 1;
            }
            else
            {
                channel = 0;
            }
        }
        public void PrevChannel()
        {
            if (channel > 0 && State == true)
            {
                channel -= 1;
            }
            else
            {
                channel = 99;
            }
        }
        public int CurrentChannel
        {
            get
            {
                return currentChannel;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    currentChannel = value;
                }
            }
        }
         public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    volume = value;
            }
        }
        public void VolumePlus()
        {
            Volume += 10;
        }
        public void VolumeMinus()
        {
            Volume -= 10;
        }
     /*   public void StatusOn()
        {
            State = true;
        }
        public void StatusOff()
        {
            State = false;
        }*/
        public override string ToString()
        {
            string state;
            if (State)
            {
                state = "работает";
            }
            else
            {
                state = "не работает";
            }

            return "Телевизор: " + Name + ", состояние: " + state + ", канал: " + channel+", громкость: " +volume;
        }
    }
}
