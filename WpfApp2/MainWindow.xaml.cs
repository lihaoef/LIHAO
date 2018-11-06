using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace WpfApp2
{

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
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int id = Thread.CurrentThread.ManagedThreadId;
            //Console.WriteLine("mToolStripButtonThreads_Click thread: " + id);

            //// grab the sync context associated to this
            //// thread (the UI thread), and save it in uiContext
            //// note that this context is set by the UI thread
            //// during Form creation (outside of your control)
            //// also note, that not every thread has a sync context attached to it.
            //SynchronizationContext uiContext = SynchronizationContext.Current;

            //// create a thread and associate it to the run method
            //Thread thread = new Thread(Run);

            //// start the thread, and pass it the UI context,
            //// so this thread will be able to update the UI
            //// from within the thread
            //thread.Start(uiContext);
            //Console.Read();
            //StorageSetting storageSetting = new StorageSetting();
            //storageSetting.IsAuto = false;
            //Serialize("e:\\te.xml", storageSetting);
            new Thread(() =>
                {
                    throw new Exception("Unhandled");

                }).Start();

            //ThreadPool.QueueUserWorkItem(new WaitCallback(x =>
            //{
            //    throw new Exception("Unhandled");

            //}));



        }

        public static void Serialize<T>(string file, T obj)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fs = File.Open(file, FileMode.Create))
            {
                serializer.Serialize(fs, obj);
            }
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

                uiContext.Post(UpdateUI, "line " + i.ToString());
            }
        }

        private static void UpdateUI(object state)
        {
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("UpdateUI thread:" + id);
            string text = state as string;
        }
    }
}
