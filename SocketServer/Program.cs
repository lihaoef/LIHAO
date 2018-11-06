using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            
            EndPoint point = new IPEndPoint(ip, 5555);
            server.Bind(point);
            server.Listen(10);
            while (true)
            {
                Socket accept = server.Accept();
                byte[] bs = new byte[1024 * 1024 * 8];
                int count = accept.Receive(bs, 1024 * 1024 * 8, SocketFlags.None);
                long start = BitConverter.ToInt64(bs, 0);
                long end = DateTime.Now.Ticks;
                Console.WriteLine(TimeSpan.FromTicks(end - start).TotalMilliseconds);
            }
        }
    }
}
