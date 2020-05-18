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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        TestEntities TestDB = new TestEntities();
        string path = @"\UserLogin.txt";
        //demoEntities.Users.Find(demoEntities.Users.Where(i=> i.Логин == Login.Text && i.Пароль == Password.Text).FirstOrDefault());
        // demoEntities.SaveChanges();
        public Auth()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            //demoEntities.Users.Find(demoEntities.Users.Where(i => i.Логин == Login.Text && i.Пароль == Password.Text).FirstOrDefault());
            var qwery = TestDB.AdminData.Where(i => i.Login == Log.Text && i.Password == Pass.Password).ToList();
            if (qwery.Count > 0)
            {
                
                Buffer.Password = Pass.Password;
                Buffer.Login = Log.Text;
                
                var customer = TestDB.AdminData.Where(i => i.Login == Log.Text).FirstOrDefault();
                //Buffer.Role = customer.IdRole;

                // Внести изменения
                //Welcome.Content = "Добро пожаловать, " + customer.LastName + " " + customer.MidName;
                // 
                //TestDB.SaveChanges();

                //if (captchaLB.Content.ToString() == captchaTXT.Text)
                //{
                //if (rememberMeCHB.IsChecked == true)
                //{
                // using (StreamWriter sw = new StreamWriter(path))
                //  {
                //    sw.Write($"{loginTXT.Text} {passwordTXT.Password}");
                //};

                //}
                // LoginUserClass.LoginUser = loginTXT.Text;

                //UserWin userWin = new UserWin();
                // this.Hide();
                // userWin.ShowDialog();
                // this.Show();
                NavigationService.Navigate(new AdminPage());

            }
            else
            {
                MessageBox.Show("Введите правильные данные", "Ошибка", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
            //}

            
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void StudBtn_Click(object sender, RoutedEventArgs e)
        {
            
            var Result = MessageBox.Show("Вы уже проходили тест в данной программе?", "Проверка", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (Result == MessageBoxResult.Yes)
            {
                //NavigationService.Navigate(new Trash());
                NavigationService.Navigate(new StudUser());
            }
            else if (Result == MessageBoxResult.No)
            {
                NavigationService.Navigate(new StudReg());
            }
            //NavigationService.Navigate(new Disclaimer());
        }
    }
}
