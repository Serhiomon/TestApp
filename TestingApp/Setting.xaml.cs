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
    /// Логика взаимодействия для Setting.xaml
    /// </summary>
    public partial class Setting : Page
    {
        TestEntities TestDB = new TestEntities();
        public Setting()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
           if (NewPass.Text == NewPass2.Text)
            {
                var customer = TestDB.AdminData
                // 
                .Where(i => i.Login == Buffer.Login && i.Password == Buffer.Password)
                .FirstOrDefault();

                // Внести изменения
                customer.Password = NewPass.Text;
                // 
                TestDB.SaveChanges();
            }
           else
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }

            
        }
    }
}
