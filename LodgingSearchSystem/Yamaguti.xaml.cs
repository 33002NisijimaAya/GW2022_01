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
    /// Yamaguti.xaml の相互作用ロジック
    /// </summary>
    public partial class Yamaguti : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Yamaguti()
        {
            InitializeComponent();
        }

        private void btSimane_Click(object sender, RoutedEventArgs e)
        {
            var simane = new Simane();
            NavigationService.Navigate(simane);
        }

        private void btHirosima_Click(object sender, RoutedEventArgs e)
        {
            var hirosima = new Hirosima();
            NavigationService.Navigate(hirosima);
        }

        private void btFukuoka_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btOita_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("yamaguchi", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("yamaguchi", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }
    }
}
