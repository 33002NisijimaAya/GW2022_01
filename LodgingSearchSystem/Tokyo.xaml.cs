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
    /// Tokyo.xaml の相互作用ロジック
    /// </summary>
    public partial class Tokyo : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Tokyo()
        {
            InitializeComponent();
        }

        
        private void btSaitama_Click(object sender, RoutedEventArgs e)
        {
            var saitama = new Saitama();
            NavigationService.Navigate(saitama);
        }

        private void btYamanasi_Click(object sender, RoutedEventArgs e)
        {
            var yamanasi = new Yamanasi();
            NavigationService.Navigate(yamanasi);
        }

        private void btKanagawa_Click(object sender, RoutedEventArgs e)
        {
            var kanagawa = new Kanagawa();
            NavigationService.Navigate(kanagawa);
        }

        private void btTiba_Click(object sender, RoutedEventArgs e)
        {
            var tiba = new Tiba();
            NavigationService.Navigate(tiba);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("tokyo", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("tokyo", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

        private void btTokyo23_Click(object sender, RoutedEventArgs e)
        {
            var tokyo23 = new Tokyo23();
            NavigationService.Navigate(tokyo23);
        }
    }
}
