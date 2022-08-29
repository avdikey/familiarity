using System;
using System.IO;
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
using Microsoft.Win32;

namespace familiarity_wpf
{
    /// <summary>
    /// Логика взаимодействия для OpenQuestionSet.xaml
    /// </summary>
    public partial class OpenQuestionSet : Window
    {
        public OpenQuestionSet()
        {
            InitializeComponent();
        }
        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Question set";
            if (Data.Endless)
            {
                ofd.DefaultExt = ".qsendless";
                ofd.Filter = "Question set for endless game (.qsendless)|*.qsendless";
            }
            else
            {
                ofd.DefaultExt = ".qsgenders";
                ofd.Filter = "Question set for game with players (.qsgenders)|*.qsgenders";
            }
            string[] lines;
            if (ofd.ShowDialog() == true)
            {
                if (Data.Endless)
                {
                    lines = File.ReadAllLines(ofd.FileName);
                    if (replace.IsChecked == true)
                        Data.questionEndless.Clear();
                    foreach (string line in lines)
                    {
                        Data.questionEndless.Add(line);
                    }
                    this.Close();
                    return;
                }
                else
                {
                    lines = File.ReadAllLines(ofd.FileName);
                    if (replace.IsChecked == true)
                    {
                        Data.questionMale.Clear();
                        Data.questionFemale.Clear();
                    }
                    foreach (string line in lines)
                    {
                        bool x = false;
                        if (line.Contains("/////"))
                        {
                            x = true;
                            continue;
                        }
                        OpenFile(line, x);
                    }
                    this.Close();
                    return;
                }
            }
        }
        private void OpenFile(string line, bool b)
        {
            switch (b)
            {
                case true:
                    Data.questionFemale.Add(line);
                    break;
                case false:
                    Data.questionMale.Add(line);
                    break;
            }
        }
    }
}
