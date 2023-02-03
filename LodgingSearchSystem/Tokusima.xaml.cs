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
    /// Tokusima.xaml の相互作用ロジック
    /// </summary>
    public partial class Tokusima : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Tokusima()
        {
            InitializeComponent();
        }

        private void btEhime_Click(object sender, RoutedEventArgs e)
        {
            var ehime = new Ehime();
            NavigationService.Navigate(ehime);
        }

        private void btHyogo_Click(object sender, RoutedEventArgs e)
        {
            var hyogo = new Hyogo();
            NavigationService.Navigate(hyogo);
        }

        private void btKagawa_Click(object sender, RoutedEventArgs e)
        {
            var kagawa = new Kagawa();
            NavigationService.Navigate(kagawa);
        }

        private void btKouti_Click(object sender, RoutedEventArgs e)
        {
            var kouti = new Kouti();
            NavigationService.Navigate(kouti);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("tokushima", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("tokushima", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

    }
}
