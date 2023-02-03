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
    /// Kumamoto.xaml の相互作用ロジック
    /// </summary>
    public partial class Kumamoto : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Kumamoto()
        {
            InitializeComponent();
        }

        private void btSaga_Click(object sender, RoutedEventArgs e)
        {
            var saga = new Saga();
            NavigationService.Navigate(saga);
        }

        private void btFukuoka_Click(object sender, RoutedEventArgs e)
        {
            var fukuoka = new Fukuoka();
            NavigationService.Navigate(fukuoka);
        }

        private void btOita_Click(object sender, RoutedEventArgs e)
        {
            var oita = new Oita();
            NavigationService.Navigate(oita);
        }

        private void btNagasaki_Click(object sender, RoutedEventArgs e)
        {
            var nagasaki = new Nagasaki();
            NavigationService.Navigate(nagasaki);
        }

        private void btMiyazaki_Click(object sender, RoutedEventArgs e)
        {
            var miyazaki = new Miyazaki();
            NavigationService.Navigate(miyazaki);
        }

        private void btKagosima_Click(object sender, RoutedEventArgs e)
        {
            var kagosima = new Kagosima();
            NavigationService.Navigate(kagosima);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("kumamoto", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("kumamoto", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }
    }
}
