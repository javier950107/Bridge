using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Radio : Device
    {
            
        private bool on = false;
        private int volume = 30;
        private int channel = 1;

        public void disable()
        {
            this.on = false;
        }

        public void enable()
        {
            this.on = true;
        }

        public int getChannel()
        {
            return this.channel;
        }

        public int getVolume()
        {
            return this.volume;
        }

        public bool isEnabled()
        {
            return this.on;
        }

        public void setChannel(int channel)
        {
            this.channel = channel;
        }

        public void setVolume(int volume)
        {
            this.volume = volume;
        }
    }
}
