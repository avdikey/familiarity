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
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        string[][][] lang = LanguageWindows.Translation;
        int original_lang;
        bool IsChanged = false;
        Brush original_theme;
        enum ThemeTypes
        {
            standart, red_aqua_green, yellow_magenta_violet,
            green_peach_crimson, gray, skyblue_orange_tomato,
            orange, blue
        }
        ThemeTypes selectedTheme;
        public SettingsWindow()
        {
            original_lang = Data.language;
            InitializeComponent();
            if (Data.language == 0)
                rbEng.IsChecked = true;
            else if (Data.language == 1)
                rbRu.IsChecked = true;
            else if (Data.language == 2)
                rbUa.IsChecked = true;
            MakeTempVar();
            this.Background = Theme.background_color;
            original_theme = Theme.background_color;
            switch (original_theme.ToString())
            {
                case "#FF7C45D6":
                    button1.BorderBrush = Theme.border_main_color;
                    button1.BorderThickness = new Thickness(3.0);
                    break;
                case "#FFFF4040":
                    button2.BorderBrush = Theme.border_main_color;
                    button2.BorderThickness = new Thickness(3.0);
                    break;
                case "#FFFFF800":
                    button3.BorderBrush = Theme.border_main_color;
                    button3.BorderThickness = new Thickness(3.0);
                    break;
                case "#FF36D986":
                    button4.BorderBrush = Theme.border_main_color;
                    button4.BorderThickness = new Thickness(3.0);
                    break;
                case "#FFFFFAF0":
                    button5.BorderBrush = Theme.border_main_color;
                    button5.BorderThickness = new Thickness(3.0);
                    break;
                case "#FF63ADD0":
                    button6.BorderBrush = Theme.border_main_color;
                    button6.BorderThickness = new Thickness(3.0);
                    break;
                case "#FFFF7400":
                    button7.BorderBrush = Theme.border_main_color;
                    button7.BorderThickness = new Thickness(3.0);
                    break;
                case "#FF0B5FA5":
                    button8.BorderBrush = Theme.border_main_color;
                    button8.BorderThickness = new Thickness(3.0);
                    break;
            }
        }
        private void MakeTempVar()
        {
            itemm.Header = lang[Data.language][2][2];
            itemmm.Header = lang[Data.language][2][3];
            itemmmm.Header = lang[Data.language][2][4];
            run1.Text = lang[Data.language][2][5];
            run2.Text = lang[Data.language][2][6];
            bt1.Content = lang[Data.language][2][0];
            bt2.Content = lang[Data.language][2][1];
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            maintabs.Margin = new Thickness(0, 0, 0, gridbuttons.ActualHeight);
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            Data.language = 0;
            MakeTempVar();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

            Data.language = 1;
            MakeTempVar();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

            Data.language = 2;
            MakeTempVar();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            Data.language = original_lang;
            if (Theme.background_color != original_theme)
            {
                switch (original_theme.ToString())
                {
                    case "#FF7C45D6":
                        Theme.ToStandartTheme();
                        break;
                    case "#FFFF4040":
                        Theme.ToFruitsTheme();
                        break;
                    case "#FFFFF800":
                        Theme.ToVioletTheme();
                        break;
                    case "#FF36D986":
                        Theme.ToSeaTheme();
                        break;
                    case "#FFFFFAF0":
                        Theme.ToGrayTheme();
                        break;
                    case "#FF63ADD0":
                        Theme.ToSunriseTheme();
                        break;
                    case "#FFFF7400":
                        Theme.ToOrangeTheme();
                        break;
                    case "#FF0B5FA5":
                        Theme.ToBlueTheme();
                        break;
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            selectedTheme = ThemeTypes.standart;
            IsChanged = true;
            Theme.ToStandartTheme();
            TempTheme();
            button1.BorderBrush = Theme.border_main_color;
            button1.BorderThickness = new Thickness(3.0);
            button8.BorderThickness = button2.BorderThickness = button3.BorderThickness = button4.BorderThickness = button5.BorderThickness = button6.BorderThickness = button7.BorderThickness = new Thickness(1);
            button8.BorderBrush = button2.BorderBrush = button3.BorderBrush = button4.BorderBrush = button5.BorderBrush = button6.BorderBrush = button7.BorderBrush = Brushes.Gray;
        }

        private void TempTheme()
        {
            this.Background = Theme.background_color;
            maintabs.BorderBrush = mainborder.BorderBrush = itemm.BorderBrush = itemmm.BorderBrush =
                itemmmm.BorderBrush = Theme.border_background_color;
            maintabs.Background = Theme.background_light_color;
            rbEng.Background = rbRu.Background = rbUa.Background = Theme.main_color;
            rbEng.BorderBrush = rbRu.BorderBrush = rbUa.BorderBrush = Theme.border_main_color;
            bt1.Background = bt2.Background = Theme.second_color;
            bt1.BorderBrush = bt2.BorderBrush = Theme.border_second_color;
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            selectedTheme = ThemeTypes.red_aqua_green;
            IsChanged = true;
            Theme.ToFruitsTheme();
            TempTheme();
            button2.BorderBrush = Theme.border_main_color;
            button2.BorderThickness = new Thickness(3.0);
            button8.BorderThickness = button1.BorderThickness = button3.BorderThickness = button4.BorderThickness = button5.BorderThickness = button6.BorderThickness = button7.BorderThickness = new Thickness(1);
            button8.BorderBrush = button1.BorderBrush = button3.BorderBrush = button4.BorderBrush = button5.BorderBrush = button6.BorderBrush = button7.BorderBrush = Brushes.Gray;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            selectedTheme = ThemeTypes.yellow_magenta_violet;
            IsChanged = true;
            Theme.ToVioletTheme();
            TempTheme();
            button3.BorderBrush = Theme.border_main_color;
            button3.BorderThickness = new Thickness(3.0);
            button8.BorderThickness = button2.BorderThickness = button1.BorderThickness = button4.BorderThickness = button5.BorderThickness = button6.BorderThickness = button7.BorderThickness = new Thickness(1);
            button8.BorderBrush = button2.BorderBrush = button1.BorderBrush = button4.BorderBrush = button5.BorderBrush = button6.BorderBrush = button7.BorderBrush = Brushes.Gray;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            selectedTheme = ThemeTypes.green_peach_crimson;
            IsChanged = true;
            Theme.ToSeaTheme();
            TempTheme();
            button4.BorderBrush = Theme.border_main_color;
            button4.BorderThickness = new Thickness(3.0);
            button8.BorderThickness = button2.BorderThickness = button3.BorderThickness = button1.BorderThickness = button5.BorderThickness = button6.BorderThickness = button7.BorderThickness = new Thickness(1);
            button8.BorderBrush = button2.BorderBrush = button3.BorderBrush = button1.BorderBrush = button5.BorderBrush = button6.BorderBrush = button7.BorderBrush = Brushes.Gray;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            selectedTheme = ThemeTypes.gray;
            IsChanged = true;
            Theme.ToGrayTheme();
            TempTheme();
            button5.BorderBrush = Theme.border_main_color;
            button5.BorderThickness = new Thickness(3.0);
            button8.BorderThickness = button2.BorderThickness = button3.BorderThickness = button4.BorderThickness = button1.BorderThickness = button6.BorderThickness = button7.BorderThickness = new Thickness(1);
            button8.BorderBrush = button2.BorderBrush = button3.BorderBrush = button4.BorderBrush = button1.BorderBrush = button6.BorderBrush = button7.BorderBrush = Brushes.Gray;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            selectedTheme = ThemeTypes.skyblue_orange_tomato;
            IsChanged = true;
            Theme.ToSunriseTheme();
            TempTheme();
            button6.BorderBrush = Theme.border_main_color;
            button6.BorderThickness = new Thickness(3.0);
            button8.BorderThickness = button2.BorderThickness = button3.BorderThickness = button4.BorderThickness = button5.BorderThickness = button1.BorderThickness = button7.BorderThickness = new Thickness(1);
            button8.BorderBrush = button2.BorderBrush = button3.BorderBrush = button4.BorderBrush = button5.BorderBrush = button1.BorderBrush = button7.BorderBrush = Brushes.Gray;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            selectedTheme = ThemeTypes.orange;
            IsChanged = true;
            Theme.ToOrangeTheme();
            TempTheme();
            button7.BorderBrush = Theme.border_main_color;
            button7.BorderThickness = new Thickness(3.0);
            button8.BorderThickness = button2.BorderThickness = button3.BorderThickness = button4.BorderThickness = button5.BorderThickness = button6.BorderThickness = button1.BorderThickness = new Thickness(1);
            button8.BorderBrush = button2.BorderBrush = button3.BorderBrush = button4.BorderBrush = button5.BorderBrush = button6.BorderBrush = button1.BorderBrush = Brushes.Gray;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            selectedTheme = ThemeTypes.blue;
            IsChanged = true;
            Theme.ToBlueTheme();
            TempTheme();
            button8.BorderBrush = Theme.border_main_color;
            button8.BorderThickness = new Thickness(3.0);
            button1.BorderThickness = button2.BorderThickness = button3.BorderThickness = button4.BorderThickness = button5.BorderThickness = button6.BorderThickness = button7.BorderThickness = new Thickness(1);
            button1.BorderBrush = button2.BorderBrush = button3.BorderBrush = button4.BorderBrush = button5.BorderBrush = button6.BorderBrush = button7.BorderBrush = Brushes.Gray;
        }
    }
}
