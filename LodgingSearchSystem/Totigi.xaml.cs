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
    /// Totigi.xaml の相互作用ロジック
    /// </summary>
    public partial class Totigi : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Totigi()
        {
            InitializeComponent();
        }

        private void btNigata_Click(object sender, RoutedEventArgs e)
        {
            var niigata = new Nigata();
            NavigationService.Navigate(niigata);
        }

        private void btFukusima_Click(object sender, RoutedEventArgs e)
        {
            var fukusima = new Fukusima();
            NavigationService.Navigate(fukusima);
        }

        private void btGunma_Click(object sender, RoutedEventArgs e)
        {
            var gunma = new Gunma();
            NavigationService.Navigate(gunma);
        }

        private void btSaimata_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btIbaraki_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("tochigi", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("tochigi", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }
    }
}
