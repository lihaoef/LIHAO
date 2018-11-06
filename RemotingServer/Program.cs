using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Text;
using System.Threading.Tasks;

namespace RemotingServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm server......");
            //Instantiate our server channel.
            IpcChannel serverchannel = new IpcChannel("testchannel");
            //Register the server channel.
            ChannelServices.RegisterChannel(serverchannel, false);
            //Register this service type.
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(DataObj.DataObj), "myObj", WellKnownObjectMode.Singleton);
            Console.WriteLine("press Enter to exit");
            Console.ReadLine();
            Console.WriteLine("server stopped");
        }
    }
}
