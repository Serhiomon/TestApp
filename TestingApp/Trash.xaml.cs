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
    /// Логика взаимодействия для Trash.xaml
    /// </summary>
    public partial class Trash : Page
    {
        static Random random = new Random();
        public Trash()
        {
            
            string lbl;
            InitializeComponent();
            for (int i = 0; i <= 20; i++)
            {
                // Buffer.TestQ[i] = random.Next(0, Buffer.MaxId);
                // label.Content = Buffer.TestQ[i] + " ";
                lbl = Convert.ToString(label.Content);


                label.Content = lbl + random.Next(0, Buffer.MaxId) + " ";
                
            }

        }
    }
}
