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
    /// Логика взаимодействия для TestForm.xaml
    /// </summary>
    public partial class TestForm : Page
    {
        TestEntities TestDB = new TestEntities();
        public static int VBuff;
        public TestForm(int v)
        {
            VBuff = v;
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            String QA;
            int Id = Buffer.TestQ[VBuff];
            var qwery = TestDB.Question.Where(i => i.IdQ == Id).FirstOrDefault();

            QA = Convert.ToString(qwery.Question1);
            Question.Text = QA;
        }
    }
}
