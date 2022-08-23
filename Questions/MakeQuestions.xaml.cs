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
        public int Question_now = 1;
        public bool isFirst = true;
        List<string> newQuestionSet = new List<string>();
        int balance;
        public MakeQuestions()
        {
            InitializeComponent();
        }
        private void ButtonLeft_Click(object sender, RoutedEventArgs e)
        {
            if (!isFirst)
            {
                newQuestionSet[Question_now-1] = tb.Text;
                tb.Text = newQuestionSet[Question_now];
                Question_now -= 1;
                textblock2.Text = "#" + Question_now.ToString();
                if (Question_now == 1)
                    isFirst = true;
                balance -= 1;
            }
        }
        private void ButtonRight_Click(object sender, RoutedEventArgs e)
        {
            if (balance==0)
                newQuestionSet.Add(tb.Text);
            else
            {
                balance += 1;
                newQuestionSet[Question_now-1] = tb.Text;
            }
            tb.Text = "";
            Question_now += 1;
            textblock2.Text = "#" + Question_now.ToString();
            isFirst = false;
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
