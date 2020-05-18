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
        static Random random2 = new Random();
        static Random random3 = new Random();
        static Random random4 = new Random();
        static Random random5 = new Random();
        static Random random6 = new Random();
        static Random random7 = new Random();
        static Random random8 = new Random();
        static Random random9 = new Random();
        static Random random10 = new Random();
        static Random random11 = new Random();
        static Random random12 = new Random();
        static Random random13 = new Random();
        static Random random14 = new Random();
        static Random random15 = new Random();
        static Random random16 = new Random();
        static Random random17 = new Random();
        static Random random18 = new Random();
        static Random random19 = new Random();
        static Random random20 = new Random();
        
        TestEntities TestDB = new TestEntities();
        public StudUser()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            int number;
            int o = 0;
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
                        Buffer.TestQ[o] = random.Next(0, Buffer.MaxId);
                        o++;
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
