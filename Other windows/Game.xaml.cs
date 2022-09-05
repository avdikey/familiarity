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
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public string question_now;
        public int Player_now = 0;
        List<string> questionSet = new List<string>();
        public int Player_count;
        string[][][] _t = LanguageWindows.Translation;

        public Game()
        {
            MakeTempVar();
            InitializeComponent();
            this.Title = _t[Data.language][0][4];
            this.Background = Theme.background_color;
            plus_size.ToolTip = _t[Data.language][7][9];
            minus_size.ToolTip = _t[Data.language][7][10];
        }
        public void MakeTempVar()
        {
            LanguageWindows.Temp[0] = _t[Data.language][6][0];
            LanguageWindows.Temp[1] = _t[Data.language][6][1];
            LanguageWindows.Temp[2] = _t[Data.language][6][2];
            LanguageWindows.Temp[3] = _t[Data.language][6][3];
            LanguageWindows.Temp[4] = _t[Data.language][6][4];
            LanguageWindows.Temp[5] = _t[Data.language][6][5];
            LanguageWindows.Temp[6] = _t[Data.language][6][6];
            LanguageWindows.Temp[7] = _t[Data.language][6][7];
            LanguageWindows.Temp[8] = _t[Data.language][6][8];
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textblock2.Text = LanguageWindows.Temp[0] + '\r';
            button_another.Visibility = Visibility.Hidden;
            button_next.Visibility = Visibility.Hidden;
            if (button_back.ActualWidth > button_start.ActualWidth)
                button_start.Width = button_back.ActualWidth;
            else
                button_back.Width = button_start.ActualWidth;
            ChangeSize();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ChangeSize();
        }
        private void ChangeSize()
        {
            TextBox1.Height = Window_Game.ActualHeight - bottom_stackpanel.ActualHeight - 40 - MainStackPanel.ActualHeight + TextBox1.ActualHeight;
            Window_Game.MinHeight = bottom_stackpanel.ActualHeight - TextBox1.ActualHeight + TextBox1.MinHeight + MainStackPanel.ActualHeight + 40;
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            Questions window1 = new Questions();
            window1.Show();
            Close();
        }

        private void button_start_Click(object sender, RoutedEventArgs e)
        {
            button_start.IsEnabled = false;
            if (Data.Endless)
            {
                textblock2.Text = LanguageWindows.Temp[5] + '\r';
                button_another.Content = LanguageWindows.Temp[6];
                button_next.Visibility = Visibility.Collapsed;
                button_another.Visibility = Visibility.Visible;
                button_next.Margin = new Thickness(0);
                button_another.HorizontalAlignment = HorizontalAlignment.Center;
                button_another.Margin = new Thickness(0, 10, 0, 20);
            }
            else
            {
                button_another.Visibility = Visibility.Visible;
                button_next.Visibility = Visibility.Visible;
                Player_count = Data.Players.Length - 1;
            }
            What_a_Question_pack();
            question_now = questionSet[new Random().Next(0, questionSet.Count)];
            TextBox1.Text = question_now;
            ChangeSize();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.FontSize < 100)
            {
                TextBox1.FontSize += 2;
                textblock_font.Text = TextBox1.FontSize.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox1.FontSize > 2)
            {
                TextBox1.FontSize -= 2;
                textblock_font.Text = TextBox1.FontSize.ToString();
            }
        }

        private void button_another_Click(object sender, RoutedEventArgs e)
        {
            What_a_Question_pack();
            question_now = questionSet[new Random().Next(0, questionSet.Count)];
            TextBox1.Text = question_now;
            if (!Data.Endless)
            {
                if (Player_now == Player_count)
                {
                    textblock2.Text += '\r';
                }
            }
        }
        private void What_a_Question_pack()
        {
            if (Data.Endless)
            {
                questionSet = Data.questionEndless;
            }
            else
            {
                if (Data.Players_gender[Player_now] == 1)
                {
                    questionSet = Data.questionMale;
                }
                else if (Data.Players_gender[Player_now] == 2)
                {
                    questionSet = Data.questionFemale;
                }
                textblock2.Text = LanguageWindows.Temp[7] + Data.Players[Player_now];
            }
            ChangeSize();
        }

        private void button_next_Click(object sender, RoutedEventArgs e)
        {
            if (Player_now == Player_count)
            {
                button_next.Content = LanguageWindows.Temp[2];
                Player_now = 0;
                What_a_Question_pack();
                question_now = questionSet[new Random().Next(0, questionSet.Count)];
                TextBox1.Text = question_now;
            }
            else
            {
                button_next.Content = LanguageWindows.Temp[2];
                Player_now += 1;
                What_a_Question_pack();
                question_now = questionSet[new Random().Next(0, questionSet.Count)];
                TextBox1.Text = question_now;
                if (Player_now == Player_count)
                {
                    button_next.Content = LanguageWindows.Temp[8];
                    textblock2.Text += '\r';
                }
            }
        }
    }
}
