﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Data;
using System.Configuration;

namespace TestingApp
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        TestEntities TestDB = new TestEntities();
        public AdminPage()
        {
            
            InitializeComponent();

            label.Content = Buffer.MaxId;

            var customer = TestDB.AdminData
            // 
            .Where(i => i.Login == Buffer.Login && i.Password == Buffer.Password)
            .FirstOrDefault();
            
            // Внести изменения
            Welcome.Content = "Добро пожаловать, " + customer.LastName + " " + customer.MidName;
            // 
            TestDB.SaveChanges();
            
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Setting());
        }

        private void CreateQ_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateQ());
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Auth());
        }

        private void StatBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateQ());
        }
    }
}
