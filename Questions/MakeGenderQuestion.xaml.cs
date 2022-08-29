using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace familiarity_wpf
{
    /// <summary>
    /// Логика взаимодействия для MakeGenderQuestion.xaml
    /// </summary>
    public partial class MakeGenderQuestion : Window
    {
        public int currentQuestionIndex = 0;
        List<string> newQuestionSet = new List<string>();
        public int currentQuestionIndex_male = 0;
        List<string> newQuestionSet_male = new List<string>();
        bool isMaleSaved = false;
        bool isFemaleSaved = false;
        public MakeGenderQuestion()
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
        private void ButtonLeftMale_Click(object sender, RoutedEventArgs e)
        {
            if (currentQuestionIndex_male == 0) return;
            if (currentQuestionIndex_male == newQuestionSet_male.Count)
                newQuestionSet_male.Add(tb_male.Text);
            else
                newQuestionSet_male[currentQuestionIndex_male] = tb_male.Text;
            currentQuestionIndex_male -= 1;
            tb_male.Text = newQuestionSet_male[currentQuestionIndex_male];
            textblock2_male.Text = "#" + (currentQuestionIndex_male + 1).ToString();
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
        private void ButtonRightMale_Click(object sender, RoutedEventArgs e)
        {
            if (currentQuestionIndex_male == newQuestionSet_male.Count)
            {
                newQuestionSet_male.Add(tb_male.Text);
                tb_male.Text = "";
            }
            else
            {
                newQuestionSet_male[currentQuestionIndex_male] = tb_male.Text;
                if (currentQuestionIndex_male + 1 == newQuestionSet_male.Count)
                    tb_male.Text = "";
                else
                    tb_male.Text = newQuestionSet_male[currentQuestionIndex_male + 1];
            }
            currentQuestionIndex_male += 1;
            textblock2_male.Text = "#" + (currentQuestionIndex_male + 1).ToString();
        }
        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void button_save_Click(object sender, RoutedEventArgs e)
        {
            isFemaleSaved = true;
            if (!isMaleSaved)
            {
                _ = MessageBox.Show("Good. Now please input question for male.", "Next", MessageBoxButton.OK);
                tabItemMale.IsSelected = true;
                return;
            }
            SaveQuestions();
        }
        private void button_saveMale_Click(object sender, RoutedEventArgs e)
        {
            isMaleSaved = true;
            if (!isFemaleSaved)
            {
                _ = MessageBox.Show("Good. Now please input question for female.", "Next", MessageBoxButton.OK);
                tabItemFemale.IsSelected = true;
                return;
            }
            SaveQuestions();
        }
        private void SaveQuestions()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "My question set";
            sfd.DefaultExt = ".qsgenders";
            sfd.Filter = "Question set for game with players (.qsgenders)|*.qsgenders";
            if (sfd.ShowDialog() == true)
            {
                File.AppendAllLines(sfd.FileName, newQuestionSet_male);
                File.AppendAllText(sfd.FileName, "/////\r\n");
                File.AppendAllLines(sfd.FileName, newQuestionSet);
                this.Close();
            }
            else
            {
                _ = MessageBox.Show("Failed to save the file. Try again");
            }
        }
    }
}
