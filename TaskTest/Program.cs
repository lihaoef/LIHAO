using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new Test().Start();
            Console.WriteLine("complete");

            Console.Read();
        }

        static async Task Test()
        {
            Task<string> task = Task.Run(() => {
                Thread.Sleep(5000);
                Console.WriteLine("test-run id is " + Thread.CurrentThread.ManagedThreadId);
                return "Hello World";
            });
            string str = await task;  //5 秒之后才会执行这里
            Console.WriteLine("test id is " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(str);
        }

        static async Task GetName()
        {
            // Delay 方法来自于.net 4.5
            await Task.Delay(1000);  // 返回值前面加 async 之后，方法里面就可以用await了
            for (int i = 0; i < 100000; i++)
            {
                int a = 1;
            }
            Console.WriteLine("Current Thread Id :{0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("In antoher thread.....");
        }
    }



    public class Test
    {
        public async void Start()
        {
            Console.WriteLine("main" + Thread.CurrentThread.ManagedThreadId);
            Task t = GetName();
            await t;
            Console.WriteLine("this is start" + Thread.CurrentThread.ManagedThreadId);
            
        }

        public async Task GetName()
        {
            Console.WriteLine(1);
            Console.WriteLine("before" + Thread.CurrentThread.ManagedThreadId);
            await GetTask();
            Console.WriteLine("after" + Thread.CurrentThread.ManagedThreadId);
        }

        public Task GetTask()
        {
            return Task.Run(() =>
            {
                int a = 1;
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(3000);
            });
        }

    }
}
