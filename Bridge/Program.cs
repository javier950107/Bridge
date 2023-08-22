using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Remote basicRemote = new Remote(new Radio());
            basicRemote.togglePower();
            basicRemote.volumeUp();
            basicRemote.volumeDown();
            basicRemote.volumeDown();
            basicRemote.volumeDown();
            basicRemote.channelUp();
            basicRemote.channelUp();
            basicRemote.channelUp();
            basicRemote.printStatus();

            Console.WriteLine("********* Change device **********");

            AdvancedRemote advancedRemote = new AdvancedRemote(new TV());
            advancedRemote.togglePower();
            advancedRemote.volumeUp();
            advancedRemote.volumeUp();
            advancedRemote.volumeUp();
            advancedRemote.volumeUp();
            advancedRemote.volumeDown();
            advancedRemote.printStatus();
        }
    }
}
