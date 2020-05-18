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
    /// Логика взаимодействия для StudReg.xaml
    /// </summary>
    public partial class StudReg : Page
    {
        static Random random = new Random();
        TestEntities context = new TestEntities();
        public StudReg()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            int number;
            number = random.Next(0, 999999999);
            var qwery = context.Stud.Where(i => i.Number == number).ToList();

            if (qwery.Count < 1)
            {
                context.Stud.Add(new Stud
                {

                    LastName = LName.Text,
                    FirstName = FName.Text,
                    MidName = MName.Text,
                    Birthday = BirthDP.DisplayDate,
                    Number = number

                }); 
                context.SaveChanges();
                Clipboard.SetData(DataFormats.Text, (Object)number);
                MessageBox.Show("Ваш уникальный индетификатор: " + number + "\n" + "Он добавлен в буфер обмена", "", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new Disclaimer());
            }

                
        }
    }
}
