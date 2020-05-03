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
        public Disclaimer()
        {
            InitializeComponent();
            
        }

        private void OkTopBtn_Click(object sender, RoutedEventArgs e)
        {
            
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
