using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal interface Device
    {
        bool isEnabled();
        void enable();
        void disable();
        int getVolume();
        void setVolume(int volume);
        int getChannel();
        void setChannel(int channel);
    }
}
