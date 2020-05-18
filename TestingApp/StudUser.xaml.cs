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
    /// Логика взаимодействия для StudUser.xaml
    /// </summary>
    public partial class StudUser : Page
    {
        static Random random = new Random();
        TestEntities TestDB = new TestEntities();
        public StudUser()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            int number;
            number = Convert.ToInt32(Number.Text);
            var qwery = TestDB.Stud.Where(i => i.FirstName == FName.Text && i.Number == number).ToList();
            if (qwery.Count > 0)
            {
                Buffer.Lname = FName.Text;
                Buffer.Number = Number.Text;
                var Result = MessageBox.Show("Показать правила?", "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (Result == MessageBoxResult.Yes)
                {
                    Buffer.YesNo = 0;
                    NavigationService.Navigate(new Disclaimer());
                }
                else if (Result == MessageBoxResult.No)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        Buffer.TestQ[i] = random.Next(0, Buffer.MaxId);
                    }
                    NavigationService.Navigate(new Test());
                }
            }
            else
            {
                MessageBox.Show("Вы ошиблись при вводе данных.", "Неудача", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            
        }
    }
}
