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
    /// Saitama.xaml の相互作用ロジック
    /// </summary>
    public partial class Saitama : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Saitama()
        {
            InitializeComponent();
        }

        private void btNigata_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btTotigi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btGunma_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btYamanasi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btTokyo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btTiba_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btIbaraki_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("saitama", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("saitama", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }
    }
}
