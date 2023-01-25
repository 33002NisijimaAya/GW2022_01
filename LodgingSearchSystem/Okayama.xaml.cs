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
    /// Okayama.xaml の相互作用ロジック
    /// </summary>
    public partial class Okayama : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Okayama()
        {
            InitializeComponent();
        }

        private void btTottori_Click(object sender, RoutedEventArgs e)
        {
            var tottori = new Tottori();
            NavigationService.Navigate(tottori);
        }

        private void btHyougo_Click(object sender, RoutedEventArgs e)
        {
            var hyogo = new Hyogo();
            NavigationService.Navigate(hyogo);
        }

        private void btHirosima_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btKagawa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("okayama", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("okayama", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }
    }
}
