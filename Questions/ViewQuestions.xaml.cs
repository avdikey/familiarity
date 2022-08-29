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
using System.Windows.Shapes;

namespace familiarity_wpf
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class ViewQuestions : Window
    {
        public ViewQuestions()
        {
            InitializeComponent();
            foreach (var c in Data.questionEndless)
            {
                lb.Items.Add(c);
            }
        }
        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}