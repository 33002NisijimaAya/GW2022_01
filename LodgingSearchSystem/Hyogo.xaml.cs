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
    /// Hyogo.xaml の相互作用ロジック
    /// </summary>
    public partial class Hyogo : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Hyogo()
        {
            InitializeComponent();
        }

        private void btTottori_Click(object sender, RoutedEventArgs e)
        {
            var tottori = new Tottori();
            NavigationService.Navigate(tottori);
        }

        private void btKyoto_Click(object sender, RoutedEventArgs e)
        {
            var kyoto = new Kyoto();
            NavigationService.Navigate(kyoto);
        }

        private void btOsaka_Click(object sender, RoutedEventArgs e)
        {
            var osaka = new Osaka();
            NavigationService.Navigate(osaka);
        }

        private void btWakayama_Click(object sender, RoutedEventArgs e)
        {
            var wakayama = new Wakayama();
            NavigationService.Navigate(wakayama);
        }

        private void btOkayama_Click(object sender, RoutedEventArgs e)
        {
            var okayama = new Okayama();
            NavigationService.Navigate(okayama);
        }

        private void btKagawa_Click(object sender, RoutedEventArgs e)
        {
            var kagawa = new Kagawa();
            NavigationService.Navigate(kagawa);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("hyogo", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("hyogo", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

    }
}
