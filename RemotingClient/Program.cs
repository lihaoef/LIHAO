using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Text;
using System.Threading.Tasks;
using DataObj;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm client......");
            IpcChannel tcc = new IpcChannel();
            ChannelServices.RegisterChannel(tcc, false);

            DataObj.DataObj myObj = (DataObj.DataObj)Activator.GetObject(typeof(DataObj.DataObj), "ipc://testchannel/myObj");

            Console.WriteLine("client send myvalue start");
            DateTime now1 = DateTime.Now;
            byte[] ago = myObj.TransportByte();
            DateTime now2 = DateTime.Now;
            Console.WriteLine(now2.Subtract(now1).TotalMilliseconds);
            Console.WriteLine("client send myvalue complete");
            Console.ReadLine();
        }
    }
}
