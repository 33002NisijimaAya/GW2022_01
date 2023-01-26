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
    /// Saga.xaml の相互作用ロジック
    /// </summary>
    public partial class Saga : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Saga()
        {
            InitializeComponent();
        }

        private void btNagasaki_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btFukuoka_Click(object sender, RoutedEventArgs e)
        {
            var fukuoka = new Fukuoka();
            NavigationService.Navigate(fukuoka);
        }

        private void btKumamoto_Click(object sender, RoutedEventArgs e)
        {
            var kumamoto = new Kumamoto();
            NavigationService.Navigate(kumamoto);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("saga", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("saga", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

    }
}
