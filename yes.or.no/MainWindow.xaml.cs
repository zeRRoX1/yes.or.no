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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace yes.or.no
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Yes(object sender, MouseEventArgs e)
        {
            if (yes.Content.ToString() == "No")
            {
                yes.Content = "Yes";
                no.Content = "No";
            }
        }
        private void Button_No(object sender, RoutedEventArgs e)
        {
            if (no.Content.ToString() == "No")
            {
                yes.Content = "No";
                no.Content = "Yes";
            }
        }
        private void Button_Yes1(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
        }
    }
}
