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
    /// Логика взаимодействия для Players_Second.xaml
    /// </summary>
    public partial class Players_Second : Window
    {
        public int Players_count;
        public int Player_now = 0;
        public bool prev = false;
        string[][][] lang = LanguageWindows.Translation;
        public Players_Second()
        {
            if (Data.Window_Choose_Sex == true)
            {
                if (Data.Players.Length != Data.Players_gender.Length)
                    Data.New_Players_Changes = true;
            }
            Players_count = Data.Players.Length;
            if (!Data.Window_Choose_Sex || Data.New_Players_Changes)
            {
                Data.Make_Size_Arrays();
                Data.New_Players_Changes = false;
            }
            MakeTempVar();
            InitializeComponent();
            this.Title = lang[Data.language][0][2];
            this.Background = Theme.background_color;
        }
        public void MakeTempVar()
        {
            LanguageWindows.Temp[0] = lang[Data.language][4][0];
            LanguageWindows.Temp[1] = lang[Data.language][4][1];
            LanguageWindows.Temp[2] = lang[Data.language][4][2];
            LanguageWindows.Temp[3] = lang[Data.language][4][3];
            LanguageWindows.Temp[4] = lang[Data.language][4][4];
            LanguageWindows.Temp[5] = lang[Data.language][4][5];
            LanguageWindows.Temp[6] = lang[Data.language][4][6];
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (button_back.ActualWidth > button_continue.ActualWidth)
            {
                button_continue.Width = button_back.ActualWidth;
            }
            else
            {
                button_back.Width = button_continue.ActualWidth;
            }
            button_continue.IsEnabled = Data.Window_Choose_Sex;
            if (Players_count > 0)
                Choose_Sex(0, true, false);
            else
                Choose_Sex(0, true, true);
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            Players window1 = new Players();
            window1.Show();
            Close();
        }

        private void button_continue_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (male_radiobutton.IsChecked == true | female_radiobutton.IsChecked == true)
                {
                    if (male_radiobutton.IsChecked == true)
                    {
                        Data.Players_gender[Player_now] = 1;
                        Data.player_have_gender[Player_now] = true;
                    }
                    else
                    {
                        Data.Players_gender[Player_now] = 2;
                        Data.player_have_gender[Player_now] = true;
                    }
                    Data.Window_Choose_Sex = true;
                    Questions window1 = new Questions();
                    window1.Show();
                    Close();
                }
                else if (Data.Window_Choose_Sex)
                {
                    Questions window1 = new Questions();
                    window1.Show();
                    Close();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                switch (Data.language)
                {
                    case 0:
                        _ = MessageBox.Show("Please select the gender of players.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                    case 1:
                        MessageBox.Show("Пожалуйста, выберите пол игроков.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                    case 2:
                        MessageBox.Show("Будь ласка, оберіть стать гравців.", "Увага", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                }

            }

        }

        private void button_previous_player_Click(object sender, RoutedEventArgs e)
        {
            Player_now -= 1;
            prev = true;
            if (Player_now == 0)
            {
                Choose_Sex(Player_now, true, false);
            }
            else
            {
                Choose_Sex(Player_now, false, false);
            }
            prev = false;
        }

        private void button_next_player_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Player_now += 1;
                if (male_radiobutton.IsChecked == true | female_radiobutton.IsChecked == true)
                {
                    if (Player_now + 1 == Players_count)
                    {
                        Choose_Sex(Player_now, false, true);
                    }
                    else
                    {
                        Choose_Sex(Player_now, false, false);
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                Player_now -= 1;
                switch (Data.language)
                {
                    case 0:
                        _ = MessageBox.Show("Please select the gender of players.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                    case 1:
                        MessageBox.Show("Пожалуйста, выберите пол игроков.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                    case 2:
                        MessageBox.Show("Будь ласка, оберіть стать гравців.", "Увага", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                }

            }
        }
        private void Choose_Sex(int i, bool first, bool next_last)
        {
            if (first)
            {
                button_previous_player.IsEnabled = false;
                if (Data.player_have_gender[Player_now])
                {
                    if (Data.Players_gender[Player_now] == 1)
                        male_radiobutton.IsChecked = true;
                    else if (Data.Players_gender[Player_now] == 2)
                        female_radiobutton.IsChecked = true;
                }
                else
                {
                    male_radiobutton.IsChecked = false;
                    female_radiobutton.IsChecked = false;
                }
            }
            else
            {
                Radio_Button_Identify();
                button_previous_player.IsEnabled = true;
            }
            if (next_last)
            {
                button_next_player.IsEnabled = false;
                button_continue.IsEnabled = true;
            }
            else
            {
                button_next_player.IsEnabled = true;
                if (!Data.Window_Choose_Sex)
                {
                    button_continue.IsEnabled = false;
                }
            }
            player_name_textblock.Text = Data.Players[i];

        }

        private void Radio_Button_Identify()
        {
            if (!prev)
            {
                if (male_radiobutton.IsChecked == true)
                {
                    Data.Players_gender[Player_now - 1] = 1;
                    Data.player_have_gender[Player_now - 1] = true;
                }
                else
                {
                    Data.Players_gender[Player_now - 1] = 2;
                    Data.player_have_gender[Player_now - 1] = true;
                }
            }
            else if (prev)
            {
                if (male_radiobutton.IsChecked == true)
                {
                    Data.Players_gender[Player_now + 1] = 1;
                    Data.player_have_gender[Player_now + 1] = true;
                }
                else if (female_radiobutton.IsChecked == true)
                {
                    Data.Players_gender[Player_now + 1] = 2;
                    Data.player_have_gender[Player_now + 1] = true;
                }

            }
            if (Data.player_have_gender[Player_now])
            {
                if (Data.Players_gender[Player_now] == 1)
                    male_radiobutton.IsChecked = true;
                else if (Data.Players_gender[Player_now] == 2)
                    female_radiobutton.IsChecked = true;
            }
            else
            {
                male_radiobutton.IsChecked = false;
                female_radiobutton.IsChecked = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (Data.language)
            {
                case 0:
                    _ = MessageBox.Show("Please select the gender of players.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 1:
                    MessageBox.Show("Пожалуйста, выберите пол игроков.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 2:
                    MessageBox.Show("Будь ласка, оберіть стать гравців.", "Інформація", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }
        }
    }
}
