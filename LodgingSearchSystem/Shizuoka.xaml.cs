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
    /// Shizuoka.xaml の相互作用ロジック
    /// </summary>
    public partial class Shizuoka : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Shizuoka()
        {
            InitializeComponent();
        }

        private void btAiti_Click(object sender, RoutedEventArgs e)
        {
            var aiti = new Aiti();
            NavigationService.Navigate(aiti);
        }

        private void btNagano_Click(object sender, RoutedEventArgs e)
        {
            var nagano = new Nagano();
            NavigationService.Navigate(nagano);
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

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("shizuoka", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("shizuoka", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }
    }
}
