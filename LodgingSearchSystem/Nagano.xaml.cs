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
    /// Nagano.xaml の相互作用ロジック
    /// </summary>
    public partial class Nagano : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Nagano()
        {
            InitializeComponent();
        }

        private void btNigata_Click(object sender, RoutedEventArgs e)
        {
            var niigata = new Nigata();
            NavigationService.Navigate(niigata);
        }

        private void btToyama_Click(object sender, RoutedEventArgs e)
        {
            var toyama = new Toyama();
            NavigationService.Navigate(toyama);
        }

        private void btGunlma_Click(object sender, RoutedEventArgs e)
        {
            var gunma = new Gunma();
            NavigationService.Navigate(gunma);
        }

        private void btGifu_Click(object sender, RoutedEventArgs e)
        {
            var gifu = new Gifu();
            NavigationService.Navigate(gifu);
        }

        private void btYamanasi_Click(object sender, RoutedEventArgs e)
        {
            var yamanasi = new Yamanasi();
            NavigationService.Navigate(yamanasi);
        }

        private void btSizuoka_Click(object sender, RoutedEventArgs e)
        {
            var sizuoka = new Shizuoka();
            NavigationService.Navigate(sizuoka);
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("nagano", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("nagano", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

        
    }
}
