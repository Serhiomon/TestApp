using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;



namespace TestingApp
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Page
    {
        static Random random = new Random();
        
        private static readonly Random Rng = new Random();
        DispatcherTimer _timer;
        TimeSpan _time;
        int[] TestQuestion = new int[20];
        
            

    public Test()
        {
            InitializeComponent();

           

            _time = TimeSpan.FromSeconds(1200);
            //_time = TimeSpan.FromSeconds(10);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) 
                {
                    _timer.Stop();
                    NavigationService.Navigate(new Statistic());
                        
                }
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            TabControl.IsEnabled = false;
            tbTime.IsEnabled = false;
            _timer.Stop();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            TabControl.IsEnabled = true;
            tbTime.IsEnabled = true;
            _timer.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            
            int newIndex = TabControl.SelectedIndex + 1;
            //if ((TabControl.SelectedItem as TabItem).Header == "20")
            //{
            //    NavigationService.Navigate(new Statistic());
            //}
           // else
            //{
                
                if (newIndex < 0)
                    newIndex = TabControl.Items.Count + 1;
                TabControl.SelectedIndex = newIndex;
           // }
            //int newIndex = TabControl.SelectedIndex + 1;
           // if (newIndex < 0)
              //  newIndex = TabControl.Items.Count + 1;
            
           // TabControl.SelectedIndex = newIndex;
        }

        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = TabControl.SelectedIndex - 1;
            if (newIndex < 0)
                newIndex = TabControl.Items.Count - 1;
            TabControl.SelectedIndex = newIndex;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i > 20; i++)
            {
                TestQuestion[i] = random.Next(0, Buffer.MaxId);

            }

            Frame_01.Navigate(new TestForm(4));
            Frame_02.Navigate(new TestForm(12));
            Frame_03.Navigate(new TestForm(2));
            Frame_04.Navigate(new TestForm(3));
            Frame_05.Navigate(new TestForm(5));
            Frame_06.Navigate(new TestForm(15));
            Frame_07.Navigate(new TestForm(9));
            Frame_08.Navigate(new TestForm(18));
            Frame_09.Navigate(new TestForm(7));
            Frame_10.Navigate(new TestForm(1));
            Frame_11.Navigate(new TestForm(13));
            Frame_12.Navigate(new TestForm(14));
            Frame_13.Navigate(new TestForm(19));
            Frame_14.Navigate(new TestForm(6));
            Frame_15.Navigate(new TestForm(11));
            Frame_16.Navigate(new TestForm(10));
            Frame_17.Navigate(new TestForm(17));
            Frame_18.Navigate(new TestForm(16));
            Frame_19.Navigate(new TestForm(8));
            Frame_20.Navigate(new TestForm(22));
        }
    }

    
}
