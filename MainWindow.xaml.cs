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

namespace familiarity_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[][][] lang = LanguageWindows.Translation;
        public MainWindow()
        {
            LanguageWindows.Translate();
            if (Data.First_launch)
            {
                Theme.ToStandartTheme();
                Data.First_launch = false;
            }
            InitializeComponent();
            MakeTempVar();
            SetTheme();
        }
        private void MakeTempVar()
        {
            button_to_questions.Content = lang[Data.language][1][0];
            button_to_players.Content = lang[Data.language][1][1];
            button_to_settings.Content = lang[Data.language][1][2];
            this.Title = lang[Data.language][0][0];
        }
        private void SetTheme()
        {
            this.Background = Theme.background_color;
            button_to_players.Background = button_to_settings.Background = button_to_questions.Background = Theme.second_color;
            button_to_players.BorderBrush = button_to_settings.BorderBrush = button_to_questions.BorderBrush = Theme.border_second_color;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Data.Endless = false;
            Players window1 = new Players();
            window1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Data.Endless = true;
            Questions window1 = new Questions();
            window1.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SettingsWindow window = new SettingsWindow();
            window.Owner = this;
            window.ShowDialog();
        }
        private void Window_Activated(object sender, EventArgs e)
        {
            button_to_questions.Width = double.NaN;
            button_to_players.Width = double.NaN;
            MakeTempVar();
            SetTheme();
        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
        }
    }
}
