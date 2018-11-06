using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    Timer timer = new Timer(2000);
            //    timer.Elapsed += Timer_Elapsed;
            //    timer.Start();
            //}
            //Console.WriteLine("finish");
            //Console.Read();

            //Console.WriteLine(Convert.ToInt32("0x0000324", 16));
            //Console.Read();

            Queue<int> que = new Queue<int>();
            for (int i = 0; i < 100; i++)
            {
                que.Enqueue(i);
            }

            foreach (var item in que)
            {
                Console.WriteLine(item);
            }
            Console.Read();

        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(DateTime.Now.ToLongTimeString());
            }
        }
    }
}

