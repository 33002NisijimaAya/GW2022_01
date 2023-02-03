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

namespace LodgingSearchSystem
{
    /// <summary>
    /// Kagawa.xaml の相互作用ロジック
    /// </summary>
    public partial class Kagawa : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Kagawa()
        {
            InitializeComponent();
        }

        private void btOkayama_Click(object sender, RoutedEventArgs e)
        {
            var okayama = new Okayama();
            NavigationService.Navigate(okayama);
        }

        private void btEhime_Click(object sender, RoutedEventArgs e)
        {
            var ehime = new Ehime();
            NavigationService.Navigate(ehime);
        }

        private void btTokusima_Click(object sender, RoutedEventArgs e)
        {
            var tokusima = new Tokusima();
            NavigationService.Navigate(tokusima);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("kagawa", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("kagawa", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

    }
}
