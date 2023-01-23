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
    /// Ibaraki.xaml の相互作用ロジック
    /// </summary>
    public partial class Ibaraki : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Ibaraki()
        {
            InitializeComponent();
        }

        private void btFukusima_Click(object sender, RoutedEventArgs e)
        {
            var fukushima = new Fukusima();
            NavigationService.Navigate(fukushima);
        }

        private void btTotigi_Click(object sender, RoutedEventArgs e)
        {
            var totigi = new Totigi();
            NavigationService.Navigate(totigi);
        }

        private void btGunma_Click(object sender, RoutedEventArgs e)
        {
            var gunma = new Gunma();
            NavigationService.Navigate(gunma);
        }

        private void btSaitama_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btTokyo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btTiba_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("ibaraki", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("ibaraki", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }
    }
}
