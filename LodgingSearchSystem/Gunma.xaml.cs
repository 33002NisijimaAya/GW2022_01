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
    /// Gunma.xaml の相互作用ロジック
    /// </summary>
    public partial class Gunma : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Gunma()
        {
            InitializeComponent();
        }

        private void btNagano_Click(object sender, RoutedEventArgs e)
        {
            var nagano = new Nagano();
            NavigationService.Navigate(nagano);
        }

        private void btNigata_Click(object sender, RoutedEventArgs e)
        {
            var niigata = new Nigata();
            NavigationService.Navigate(niigata);
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

        private void btSaimata_Click(object sender, RoutedEventArgs e)
        {
            var saitama = new Saitama();
            NavigationService.Navigate(saitama);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("gunma", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("gunma", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }
    }
}
