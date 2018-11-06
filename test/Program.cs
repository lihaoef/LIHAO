using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;
using System.Threading;

namespace test
{
    public delegate void SetDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //while (queue.Count != 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}
            //Console.WriteLine("end");
            //Console.Read();

            //ManualResetEvent waitEvent = new ManualResetEvent(false);
            //Console.WriteLine("start");
            //waitEvent.WaitOne();
            //Console.WriteLine("end");

            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //dic.Add(1, 1);

            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        dic.Add(2, 2);
            //        System.Threading.Thread.Sleep(1000);
            //    }
            //});

            #region  线程间通过代理进行通信
            //Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);
            //SetDelegate del = null;
            //Test ttt = new Test();
            //ttt.Exe();
            //ttt.Myevent += Ttt_Myevent;

            //Task t1 = Task.Run(() =>
            //{
            //    del = () =>
            //    {
            //        Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);
            //    };
            //});
            ////System.Threading.Thread.Sleep(10);
            ////del();

            //for (int i = 0; i < 100; i++)
            //{
            //    System.Threading.Thread.Sleep(1000);
            //}
            //Console.Read();
            #endregion


            //Timer t = new Timer(10);
            //t.Elapsed += (x, y)=>
            //{
            //    var vas = dic.ToList();
            //    foreach (var item in vas)
            //    {
            //        if (item.Key % 2 == 1)
            //        {
            //            dic.Remove(item.Key);
            //        }
            //        else
            //        {
            //            Console.WriteLine(item.Key);
            //        }
            //    }
            //};
            //t.Start();

            //System.Threading.Thread.Sleep(100);
            //Task.Factory.StartNew(() =>
            //{
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        dic.Add(i, i);
            //    }
            //});
            //Console.Read();

            #region  测试属性只覆盖父类get的情况
            //SendMessage me = new SendMessage();
            //me.Id = 33;
            //Console.WriteLine(me.Id);
            //Console.Read();
            #endregion

            #region 测试静态类变量
            //Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine(new ReceiveMessage().Id);
            //});

            //Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine(new ReceiveMessage().Id);

            //});

            //Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine(new ReceiveMessage().Id);

            //});
            //Console.Read();
            #endregion

            //var mes = new ReceiveMessage();
            //mes.Id = 20;
            //Serialize(@"c:\windows\hao.xml", mes);


            //Console.WriteLine(Environment.CurrentDirectory);
            //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            //System.Diagnostics.Process pro = null;
            ////Task.Run(() =>
            ////{
            //pro = System.Diagnostics.Process.Start("..\\Environment.exe");
            //pro = System.Diagnostics.Process.Start("..\\AppDomain.exe");
            ////});
            ////System.Threading.Thread.Sleep(100);
            ////pro.WaitForExit();
            //Console.Read();
            //Message m1 = new SendMessage();
            //string ss = m1.GetType().Name;
            //byte[] bs1 = File.ReadAllBytes(@"e:\ss1.txt");
            //byte[] bs2 = File.ReadAllBytes(@"e:\ss2.txt");

            //List<string> ss2 = new List<string>();
            //ss2.Add("1");
            //ss2.Add("2");
            //foreach (var item in ss2)
            //{
            //    if (item == "1")
            //    {
            //        ss2.Clear();
            //        break;
            //    }
            //}

            //string[] s = "ab     c".Split(' ');
            //Test test = new Test();
            ////test.DoSomethingAsync();
            ////Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);
            //Console.WriteLine(nameof(test.Exe));
            //GlobalSetting.SaveAll();
            //Console.Read();
            //List<Data> datas = new List<Data>();
            //for (int i = 0; i < 1000; i++)
            //{
            //    datas.Add(new Data { Num1 = i, Num2 = i, Num3 = i, Num4 = i });
            //}
            //Serialize("E:\\test.xml", datas);

            //LocalDataStoreSlot localDataStoreSlot = Thread.AllocateNamedDataSlot("hao");
            //Thread.SetData(Thread.GetNamedDataSlot("hao"), "abcd");

            //ThreadLocal<string> threadLocal = new ThreadLocal<string>();

            //Thread t = new Thread(() =>
            //{
            //    Thread.SetData(Thread.GetNamedDataSlot("hao"), "12345");
            //    str = "1234";
            //    threadLocal.Value = "jjjj";
            //    Console.WriteLine(Thread.GetData(Thread.GetNamedDataSlot("hao")) + "\t" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            //    //Thread.FreeNamedDataSlot("hao");

            //    Thread.me
            //});
            //t.Start();
            //t.Join();

            //object obj = Thread.GetData(Thread.GetNamedDataSlot("hao"));
            //Console.WriteLine(Thread.GetData(Thread.GetNamedDataSlot("hao")) + "\t" + System.Threading.Thread.CurrentThread.ManagedThreadId);

            //Console.Read();

            //int id = Thread.CurrentThread.ManagedThreadId;
            //Console.WriteLine("mToolStripButtonThreads_Click thread: " + id);

            //// grab the sync context associated to this
            //// thread (the UI thread), and save it in uiContext
            //// note that this context is set by the UI thread
            //// during Form creation (outside of your control)
            //// also note, that not every thread has a sync context attached to it.
            //SynchronizationContext uiContext = new SynchronizationContext();

            //// create a thread and associate it to the run method
            //Thread thread = new Thread(Run);

            //// start the thread, and pass it the UI context,
            //// so this thread will be able to update the UI
            //// from within the thread
            //thread.Start(uiContext);
            //Console.Read();

            StorageSetting setting = new StorageSetting();
            setting.IsAuto = false;
            Serialize("e:\\te.xml", setting);
            setting.IsAuto = true;
            Serialize("e:\\te.xml", setting);
            setting.IsAuto = false;
            Serialize("e:\\te.xml", setting);
            setting.IsAuto = true;
            Serialize("e:\\te.xml", setting);
        }

        public static void Run(object state)
        {
            // lets see the thread id
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("Run thread: " + id);

            // grab the context from the state
            SynchronizationContext uiContext = state as SynchronizationContext;

            for (int i = 0; i < 10; i++)
            {
                // normally you would do some code here
                // to grab items from the database. or some long
                // computation
                Thread.Sleep(10);

                // use the ui context to execute the UpdateUI method,
                // this insure that the UpdateUI method will run on the UI thread.

                uiContext.Send(UpdateUI, "line " + i.ToString());
            }
        }

        private static void UpdateUI(object state)
        {
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("UpdateUI thread:" + id);
            string text = state as string;
        }


        [ThreadStatic]
        static string str = "abc";


        public static void Serialize<T>(string file, T obj)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            System.IO.FileStream fs = File.Open(file, FileMode.Create);
            serializer.Serialize(fs, obj);
        }

        private static void Ttt_Myevent(object sender, EventArgs e)
        {

        }
    }

    public class StorageSetting
    {
        public bool IsAuto { get; set; }
        public bool IsRawDataStored { get; set; }
        public bool IsReportStored { get; set; }
        public bool IsResultStored { get; set; }
        public StorageSetting()
        {
            IsAuto = true;
            IsRawDataStored = false;
            IsReportStored = true;
            IsResultStored = true;
        }
    }

    [Flags]
    public enum FileType
    {
        /// <summary>
        /// 原始图
        /// </summary>
        RawData = 1,
        /// <summary>
        /// 结果数据
        /// </summary>
        Result = 2,
        /// <summary>
        /// 报告
        /// </summary>
        Report = 4,
    }

    public class Data
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public int Num4 { get; set; }
    }

    public abstract class Message
    {
        public virtual int Id { get; set; }
    }

    public class SendMessage : Message
    {
        public override int Id
        {
            get
            {
                return 3;
            }
        }
    }

    public class ReceiveMessage
    {
        private static int _id;
        public int Id
        {
            get; set;
        }
        public ReceiveMessage()
        {
            Id = _id++;
        }
    }

    public class Test
    {
        public event EventHandler Myevent;

        public async Task Exe()
        {

            int a = 1;
            await Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    a++;
                }

            });
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(1000);
            }
        }

        public async Task DoSomethingAsync()
        {
            int val = 12;
            await Task.Delay(1000);
            val *= 2;
            await Task.Delay(1000);
            val *= 2;

        }

        public void E2()
        {

        }
    }

    public static class GlobalSetting
    {
        static GlobalSetting()
        {
            EndPoint = "1";
            Recipe = "2";
            Wash = "3";
        }

        public static string EndPoint { get; set; }
        public static string Recipe { get; set; }
        public static string Wash { get; set; }

        public static void SaveAll()
        {
            PropertyInfo[] properties =  typeof(GlobalSetting).GetProperties();
            foreach (var item in properties)
            {
                Console.WriteLine(item.GetValue(null));
            }
        }
    }
}
