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
    /// Miyazaki.xaml の相互作用ロジック
    /// </summary>
    public partial class Miyazaki : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Miyazaki()
        {
            InitializeComponent();
        }

        private void btOita_Click(object sender, RoutedEventArgs e)
        {
            var oita = new Oita();
            NavigationService.Navigate(oita);
        }

        private void btKumamoto_Click(object sender, RoutedEventArgs e)
        {
            var kumamoto = new Kumamoto();
            NavigationService.Navigate(kumamoto);
        }

        private void btKagosima_Click(object sender, RoutedEventArgs e)
        {
            var kagosima = new Kagosima();
            NavigationService.Navigate(kagosima);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("miyazaki", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("miyazaki", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

    }
}
