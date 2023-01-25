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
    /// Gifu.xaml の相互作用ロジック
    /// </summary>
    public partial class Gifu : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Gifu()
        {
            InitializeComponent();
        }

        private void btToyama_Click(object sender, RoutedEventArgs e)
        {
            var toyama = new Toyama();
            NavigationService.Navigate(toyama);
        }

        private void btIshikawa_Click(object sender, RoutedEventArgs e)
        {
            var ishikawa = new Ishikawa();
            NavigationService.Navigate(ishikawa);
        }

        private void btFukui_Click(object sender, RoutedEventArgs e)
        {
            var fukui = new Fukui();
            NavigationService.Navigate(fukui);
        }

        private void btNagano_Click(object sender, RoutedEventArgs e)
        {
            var nagano = new Nagano();
            NavigationService.Navigate(nagano);
        }

        private void btSiga_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btMie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btAiti_Click(object sender, RoutedEventArgs e)
        {
            var aiti = new Aiti();
            NavigationService.Navigate(aiti);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("gifu", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("gifu", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

    }
}
