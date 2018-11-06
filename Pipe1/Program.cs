using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pipe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread receiveDataThread = new Thread(new ThreadStart(ReceiveDataFromClient));
            receiveDataThread.IsBackground = true;
            receiveDataThread.Start();

            Console.Read();

        }

        private static void ReceiveDataFromClient()
        {
            while (true)
            {
                try
                {
                    var _pipeServer = new NamedPipeServerStream("closePipe", PipeDirection.InOut, 10);
                    _pipeServer.WaitForConnection(); //Waiting
                    StreamReader sr = new StreamReader(_pipeServer);
                    BinaryReader br = new BinaryReader(_pipeServer);
                    byte[] bs = new byte[1024 * 1024 * 8];
                    int readCount = _pipeServer.Read(bs, 0, 1024 * 1024 * 8);
                    long start = BitConverter.ToInt64(bs, 0);
                    long end = DateTime.Now.Ticks;
                    Console.WriteLine(TimeSpan.FromTicks(end - start).TotalMilliseconds);
                    Thread.Sleep(1000);
                    //sr.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
