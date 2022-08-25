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
        public int currentQuestionIndex = 0;
        List<string> newQuestionSet = new List<string>();
        public MakeQuestions()
        {
            InitializeComponent();
        }
        private void ButtonLeft_Click(object sender, RoutedEventArgs e)
        {
            if (currentQuestionIndex == 0) return;
            if (currentQuestionIndex == newQuestionSet.Count)
                newQuestionSet.Add(tb.Text);
            else 
                newQuestionSet[currentQuestionIndex] = tb.Text;
            currentQuestionIndex -= 1;
            tb.Text = newQuestionSet[currentQuestionIndex];
            textblock2.Text = "#" + (currentQuestionIndex + 1).ToString();
        }
        private void ButtonRight_Click(object sender, RoutedEventArgs e)
        {
            if (currentQuestionIndex == newQuestionSet.Count)
            {
                newQuestionSet.Add(tb.Text);
                tb.Text = "";
            }
            else
            {
                newQuestionSet[currentQuestionIndex] = tb.Text;
                if (currentQuestionIndex + 1 == newQuestionSet.Count)
                    tb.Text = "";
                else
                    tb.Text = newQuestionSet[currentQuestionIndex + 1];
            }
            currentQuestionIndex += 1;
            textblock2.Text = "#" + (currentQuestionIndex + 1).ToString();
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
