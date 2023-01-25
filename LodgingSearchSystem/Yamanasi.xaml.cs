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
    /// Yamanasi.xaml の相互作用ロジック
    /// </summary>
    public partial class Yamanasi : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Yamanasi()
        {
            InitializeComponent();
        }

        private void btKanagawa_Click(object sender, RoutedEventArgs e)
        {
            var kanagawa = new Kanagawa();
            NavigationService.Navigate(kanagawa);
        }

        private void btTokyo_Click(object sender, RoutedEventArgs e)
        {
            var tokyo = new Tokyo();
            NavigationService.Navigate(tokyo);
        }

        private void btSaitama_Click(object sender, RoutedEventArgs e)
        {
            var saitama = new Saitama();
            NavigationService.Navigate(saitama);
        }

        private void btNagano_Click(object sender, RoutedEventArgs e)
        {
            var nagano = new Nagano();
            NavigationService.Navigate(nagano);
        }

        private void btKanaagawa_Click(object sender, RoutedEventArgs e)
        {
            var sizuoka = new Kanagawa();
            NavigationService.Navigate(sizuoka);
        }

        private void btSizuoka_Click(object sender, RoutedEventArgs e)
        {
            var sizuoka = new Shizuoka();
            NavigationService.Navigate(sizuoka);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("yamanashi", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("yamanashi", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }
    }
}
