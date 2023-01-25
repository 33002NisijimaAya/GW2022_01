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
    /// Toyama.xaml の相互作用ロジック
    /// </summary>
    public partial class Toyama : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Toyama()
        {
            InitializeComponent();
        }

        private void btIsikawa_Click(object sender, RoutedEventArgs e)
        {
            var ishikawa = new Ishikawa();
            NavigationService.Navigate(ishikawa);
        }

        private void btNiigata_Click(object sender, RoutedEventArgs e)
        {
            var niigata = new Nigata();
            NavigationService.Navigate(niigata);
        }

        private void btNagano_Click(object sender, RoutedEventArgs e)
        {
            var nagano = new Nagano();
            NavigationService.Navigate(nagano);

        }

        private void btGifu_Click(object sender, RoutedEventArgs e)
        {
            var gifu = new Gifu();
            NavigationService.Navigate(gifu);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("toyama", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("toyama", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }
    }
}
