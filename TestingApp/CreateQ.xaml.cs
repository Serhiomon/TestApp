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
    /// Логика взаимодействия для CreateQ.xaml
    /// </summary>
    public partial class CreateQ : Page
    {
        public CreateQ()
        {
            InitializeComponent();
        }


        private void QCB_DropDownClosed(object sender, EventArgs e)
        {
            if (QCB.Text == "Вопрос с выбором ответа")
            {
                Q.IsEnabled = true;
                A.Visibility = Visibility.Hidden;
                Atxt.Visibility = Visibility.Hidden;
                BlockLBL.Visibility = Visibility.Visible;
                BlockA.Visibility = Visibility.Visible;
                Save.IsEnabled = true;
            }
            else if (QCB.Text == "Вопрос с вводом ответа")
            {
                Q.IsEnabled = true;
                A.Visibility = Visibility.Visible;
                Atxt.Visibility = Visibility.Visible;
                BlockLBL.Visibility = Visibility.Hidden;
                BlockA.Visibility = Visibility.Hidden;
                Save.IsEnabled = true;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
