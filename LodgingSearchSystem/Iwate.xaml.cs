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

namespace LodgingSearchSystem {
    /// <summary>
    /// Iwate.xaml の相互作用ロジック
    /// </summary>
    public partial class Iwate : Page {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Iwate() {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e) {

        }

        private void btHome_Click(object sender, RoutedEventArgs e)
        {
            var japan = new Japan();
            NavigationService.Navigate(japan);
        }

        private void btAkita_Click(object sender, RoutedEventArgs e)
        {
            var Akita = new Akita();
            NavigationService.Navigate(Akita);
        }

        private void btMiyagi_Click(object sender, RoutedEventArgs e)
        {
            var Miyagi = new Miyagi();
            NavigationService.Navigate(Miyagi);
        }

        private void btAomori_Click(object sender, RoutedEventArgs e)
        {
            var Aomori = new Aomori();
            NavigationService.Navigate(Aomori);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("iwate", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("iwate", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }
    }
}
