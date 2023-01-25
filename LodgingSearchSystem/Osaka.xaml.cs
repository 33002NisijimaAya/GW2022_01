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
    /// Osaka.xaml の相互作用ロジック
    /// </summary>
    public partial class Osaka : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Osaka()
        {
            InitializeComponent();
        }

        private void btHyogo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btNara_Click(object sender, RoutedEventArgs e)
        {
            var nara = new Nara();
            NavigationService.Navigate(nara);
        }

        private void btKyoto_Click(object sender, RoutedEventArgs e)
        {
            var kyoto = new Kyoto();
            NavigationService.Navigate(kyoto);
        }

        private void btOsaka_Click(object sender, RoutedEventArgs e)
        {
            var osakashi = new Osakashi();
            NavigationService.Navigate(osakashi);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("osaka", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("osaka", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

    }
}
