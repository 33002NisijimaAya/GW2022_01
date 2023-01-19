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
    /// Hokkaido.xaml の相互作用ロジック
    /// </summary>
    public partial class Hokkaido : Page {
        public Hokkaido() {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e) {
            
        }

        private void btsupporo_Click(object sender, RoutedEventArgs e)
        {
            var sapporo = new sapporo();
            NavigationService.Navigate(sapporo);
        }

        private void btZyozankei_Click(object sender, RoutedEventArgs e)
        {
            HotelSearch();
        }

        private void HotelSearch()
        {
            //var hotelShow = new HotelShow();
            //NavigationService.Navigate(hotelShow);
        }

    }
}
