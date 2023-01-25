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
    /// Kanagawa.xaml の相互作用ロジック
    /// </summary>
    public partial class Kanagawa : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Kanagawa()
        {
            InitializeComponent();
        }

        private void btSizuoka_Click(object sender, RoutedEventArgs e)
        {
            var sizuoka = new Shizuoka();
            NavigationService.Navigate(sizuoka);
        }

        private void btYamanasi_Click(object sender, RoutedEventArgs e)
        {
            var yamanasi = new Yamanasi();
            NavigationService.Navigate(yamanasi);
        }

        private void btTokyo_Click(object sender, RoutedEventArgs e)
        {
            var tokyo = new Tokyo();
            NavigationService.Navigate(tokyo);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("kanagawa", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("kanagawa", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

        private void btTiba_Click(object sender, RoutedEventArgs e)
        {
            var tiba = new Tiba();
            NavigationService.Navigate(tiba);
        }
    }
}
