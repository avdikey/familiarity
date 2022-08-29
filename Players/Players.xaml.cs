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
    /// Логика взаимодействия для Players.xaml
    /// </summary>
    public partial class Players : Window
    {
        string[][][] lang = LanguageWindows.Translation;
        public Players()
        {
            MakeTempVar();
            InitializeComponent();
            this.Title = lang[Data.language][0][1];
            this.Background = Theme.background_color;
        }
        public void MakeTempVar()
        {
            LanguageWindows.Temp[0] = lang[Data.language][3][0];
            LanguageWindows.Temp[1] = lang[Data.language][3][1];
            LanguageWindows.Temp[2] = lang[Data.language][3][2];
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ChangeSize();
            if (button_back.ActualWidth > button_continue.ActualWidth)
                button_continue.Width = button_back.ActualWidth;
            else
                button_back.Width = button_continue.ActualWidth;
            if (Data.Players != null)
            {
                for (int i = 0; i < Data.Players.Length; i++)
                {
                    if (i == Data.Players.Length - 1)
                        TextBox1.Text += Data.Players[i];
                    else
                        TextBox1.Text += Data.Players[i] + '\n';
                }
            }
        }
        private void ChangeSize()
        {
            Window_Players.MinHeight = SecondStackPanel.ActualHeight + MainStackPanel.ActualHeight - TextBox1.ActualHeight + TextBox1.MinHeight + 40;
            TextBox1.Height = Window_Players.ActualHeight - SecondStackPanel.ActualHeight - 40 -
                MainStackPanel.ActualHeight + TextBox1.ActualHeight;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ChangeSize();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (Data.language)
            {
                case 0:
                    MessageBox.Show("Please enter players nicknames. One line - one player.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 1:
                    MessageBox.Show("Пожалуйста, введите никнеймы игроков. В каждой строке должен быть один игрок.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 2:
                    MessageBox.Show("Будь ласка, введіть нікнейми гравців. В одному рядку має бути нікнейм одного гравця.", "Інформація", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                Data.Players = TextBox1.Text.Split('\n');
                if (Data.Players.Length == 1)
                {
                    switch (Data.language)
                    {
                        case 0:
                            MessageBox.Show("Minimal number of players  - 2 players.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                        case 1:
                            MessageBox.Show("Минимальное количество игроков - 2 игрока.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                        case 2:
                            MessageBox.Show("Мінімальна кількість гравців - 2 гравця.", "Увага", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }
                }
                else
                {
                    Players_Second window1 = new Players_Second();
                    window1.Show();
                    this.Close();
                }
            }
            else
            {
                switch (Data.language)
                {
                    case 0:
                        MessageBox.Show("Please enter players nicknames.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                    case 1:
                        MessageBox.Show("Пожалуйста, введите никнеймы игроков.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                    case 2:
                        MessageBox.Show("Будь ласка, введіть нікнейми гравців.", "Увага", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                }

            }
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();
            this.Close();
        }
    }
}
