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

namespace LodgingSearchSystem
{
    /// <summary>
    /// Ehime.xaml の相互作用ロジック
    /// </summary>
    public partial class Ehime : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Ehime()
        {
            InitializeComponent();
        }

        private void btKagawa_Click(object sender, RoutedEventArgs e)
        {
            var kagawa = new Kagawa();
            NavigationService.Navigate(kagawa);
        }

        private void btHirosima_Click(object sender, RoutedEventArgs e)
        {
            var hirosima = new Hirosima();
            NavigationService.Navigate(hirosima);
        }

        private void btYamaguti_Click(object sender, RoutedEventArgs e)
        {
            var yamaguti = new Yamaguti();
            NavigationService.Navigate(yamaguti);
        }

        private void btKouti_Click(object sender, RoutedEventArgs e)
        {
            var kouti = new Kouti();
            NavigationService.Navigate(kouti);
        }

        private void btOita_Click(object sender, RoutedEventArgs e)
        {
            var oita = new Oita();
            NavigationService.Navigate(oita);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("ehime", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("ehime", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

    }
}
