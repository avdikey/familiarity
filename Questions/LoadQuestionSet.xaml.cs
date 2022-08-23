﻿using System;
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
            MakeQuestions mq = new MakeQuestions();
            mq.Background = Theme.background_light_color;
            mq.BorderThickness = new Thickness(3);
            mq.BorderBrush = Theme.border_background_color;
            mq.ShowDialog();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btViewLoadQuestion_Click(object sender, RoutedEventArgs e)
        {

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