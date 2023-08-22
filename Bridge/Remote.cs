using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Remote
    {
        private Device _device;

        public Remote(Device device)
        {
            this._device = device;
        }

        public void togglePower()
        {
            if (this._device.isEnabled())
            {
                this._device.disable();
            }
            else
            {
                this._device.enable();
            }
        }

        public void volumeDown()
        {
            if (this._device.isEnabled())
            {
                this._device.setVolume(this._device.getVolume() - 1);
            }
        }

        public void volumeUp()
        {
            if (this._device.isEnabled())
            {
                this._device.setVolume(this._device.getVolume() + 1);
            }
        }

        public void channelDown()
        {
            if (this._device.isEnabled())
            {
                this._device.setChannel(_device.getChannel() - 1);
            }
        }

        public void channelUp()
        {
            if (this._device.isEnabled())
            {
                this._device.setChannel(_device.getChannel() + 1);
            }
        }

        public void printStatus()
        {
            Console.WriteLine("Status device: "+ this._device.isEnabled());
            Console.WriteLine("Get volume: " + this._device.getVolume());
            Console.WriteLine("Get channel: "+ this._device.getChannel());

        }

    }
}
