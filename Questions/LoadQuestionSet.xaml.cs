using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для LoadQuestionSet.xaml
    /// </summary>
    public partial class LoadQuestionSet : Window
    {
        public LoadQuestionSet()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (Data.Endless)
            {
                MakeQuestions mq = new MakeQuestions();
                mq.Background = Theme.background_light_color;
                mq.BorderThickness = new Thickness(3);
                mq.BorderBrush = Theme.border_background_color;
                mq.ShowDialog();
            }
            else
            {
                MakeGenderQuestion mq = new MakeGenderQuestion();
                mq.Background = Theme.background_light_color;
                mq.BorderThickness = new Thickness(3);
                mq.BorderBrush = Theme.border_background_color;
                mq.ShowDialog();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            OpenQuestionSet oqs = new OpenQuestionSet()
            {
                Background = Theme.background_light_color,
                BorderThickness = new Thickness(3),
                BorderBrush = Theme.border_background_color,
                Owner = this
            };
            oqs.ShowDialog();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
