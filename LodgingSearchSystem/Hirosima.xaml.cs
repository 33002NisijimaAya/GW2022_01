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
    /// Hirosima.xaml の相互作用ロジック
    /// </summary>
    public partial class Hirosima : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Hirosima()
        {
            InitializeComponent();
        }

        private void btSimane_Click(object sender, RoutedEventArgs e)
        {
            var simane = new Simane();
            NavigationService.Navigate(simane);
        }

        private void btTottori_Click(object sender, RoutedEventArgs e)
        {
            var tottori = new Tottori();
            NavigationService.Navigate(tottori);
        }

        private void btOkayama_Click(object sender, RoutedEventArgs e)
        {
            var okayama = new Okayama();
            NavigationService.Navigate(okayama);
        }

        private void btYamaguti_Click(object sender, RoutedEventArgs e)
        {
            var yamaguti = new Yamaguti();
            NavigationService.Navigate(yamaguti);
        }

        private void btEhime_Click(object sender, RoutedEventArgs e)
        {
            var ehime = new Ehime();
            NavigationService.Navigate(ehime);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("hiroshima", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("hiroshima", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

    }
}
