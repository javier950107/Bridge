using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class AdvancedRemote : Remote
    {

        private Device _device;

        public AdvancedRemote(Device device) : base(device) {
            this._device = device;
        }
        
        public void mute()
        {
            _device.setVolume(0);
        }
    }
}
