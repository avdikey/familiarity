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
    /// Логика взаимодействия для MakeQuestions.xaml
    /// </summary>
    public partial class MakeQuestions : Window
    {
        public int Players_count;
        public int Player_now = 0;
        public bool prev = false;
        public MakeQuestions()
        {
            InitializeComponent();
        }
        private void ButtonLeft_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonRight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
