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
    /// Nigata.xaml の相互作用ロジック
    /// </summary>
    public partial class Nigata : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Nigata()
        {
            InitializeComponent();
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("niigata", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("niigata", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

        private void btYamagata_Click(object sender, RoutedEventArgs e)
        {
            var yamagata = new Yamagata();
            NavigationService.Navigate(yamagata);
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

        private void btNagano_Click(object sender, RoutedEventArgs e)
        {
            var nagano = new Nagano();
            NavigationService.Navigate(nagano);
        }

        private void btToyama_Click(object sender, RoutedEventArgs e)
        {
            var toyama = new Toyama();
            NavigationService.Navigate(toyama);
        }
    }
}
