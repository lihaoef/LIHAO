using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress address = IPAddress.Parse("127.0.0.1");
            client.Connect(address, 5555);
            byte[] bs = new byte[1024 * 1024 * 8];
            byte[] b2 = BitConverter.GetBytes(DateTime.Now.Ticks);
            for (int i = 0; i < b2.Length; i++)
            {
                bs[i] = b2[i];
            }
            int count = client.Send(bs);
            Console.WriteLine(count);
            Console.Read();
        }
    }
}
