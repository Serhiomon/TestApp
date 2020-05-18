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

namespace TestingApp
{
    /// <summary>
    /// Логика взаимодействия для Disclaimer.xaml
    /// </summary>
    public partial class Disclaimer : Page
    {
        static Random random = new Random();
        public Disclaimer()
        {   if (Buffer.YesNo == 0)
            {
                for (int i = 0; i < 20; i++)
                {
                    Buffer.TestQ[i] = random.Next(0, Buffer.MaxId);
                }
            }
            else
            {

            }
            

            InitializeComponent();
            
        }

        private void OkTopBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Test());
        }

        private void OkTopCB_Checked(object sender, RoutedEventArgs e)
        {
            OkTopBtn.IsEnabled = true;
        }
        private void OkTopCB_UnChecked(object sender, RoutedEventArgs e)
        {
            OkTopBtn.IsEnabled = false;
        }
    }
}
