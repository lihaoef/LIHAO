using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Security.Principal;

namespace Pipe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread pipeThread = new Thread(new ThreadStart(SendData));
            pipeThread.IsBackground = true;
            pipeThread.Start();


            Console.Read();
        }

        private static void SendData()
        {
            try
            {
                var _pipeClient = new NamedPipeClientStream(".", "closePipe", PipeDirection.InOut, PipeOptions.None, TokenImpersonationLevel.Impersonation);
                _pipeClient.Connect();
                //StreamWriter sw = new StreamWriter(_pipeClient);
                byte[] bs = new byte[1024*1024*8];
                byte[] b2 = BitConverter.GetBytes(DateTime.Now.Ticks);
                for (int j = 0; j < b2.Length; j++)
                {
                    bs[j] = b2[j];
                }
                _pipeClient.Write(bs, 0, 1024 * 1024 * 8);
                _pipeClient.Flush();
                //sw.WriteLine("Exit");
                //sw.Flush();
                //Thread.Sleep(1000);
                //sw.Close();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
