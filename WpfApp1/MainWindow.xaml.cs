using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Threading;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ////web.Navigate("http://www.cygnusbio.com/");
            //int a = 1;
            //Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);
            //await Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);

            //    for (int i = 0; i < 100000; i++)
            //    {
            //        a++;
            //        //System.Threading.Thread.Sleep(1000);
            //    }
            //});
            //Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);

            //for (int i = 0; i < 100; i++)
            //{
            //    //System.Threading.Thread.Sleep(1000);
            //    a++;
            //}
            MainViewModel mainViewModel = this.DataContext as MainViewModel;
            SynchronizationContext synchronizationContext = SynchronizationContext.Current;
            Task.Run(() =>
            {
                mainViewModel.IsChecked = true;
                for (int i = 0; i < 100; i++)
                {
                    //this.Dispatcher.Invoke(new Action(() =>
                    //{
                    Thread.
                        mainViewModel.Items.Add(i.ToString());

                    //}));
                }
            });
            
        }
    }

    public class Test
    {
        public event EventHandler Myevent;

        public async Task Exe()
        {

            int a = 1;
            await Task.Run(() =>
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

        public void E2()
        {

        }
    }
}
