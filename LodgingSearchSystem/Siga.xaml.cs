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
    /// Siga.xaml の相互作用ロジック
    /// </summary>
    public partial class Siga : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Siga()
        {
            InitializeComponent();
        }

        private void btFukui_Click(object sender, RoutedEventArgs e)
        {
            var fukui = new Fukui();
            NavigationService.Navigate(fukui);
        }

        private void btGifu_Click(object sender, RoutedEventArgs e)
        {
            var gifu = new Gifu();
            NavigationService.Navigate(gifu);
        }

        private void btKyoto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btMie_Click(object sender, RoutedEventArgs e)
        {
            var mie = new Mie();
            NavigationService.Navigate(mie);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("shiga", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("shiga", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

    }
}
