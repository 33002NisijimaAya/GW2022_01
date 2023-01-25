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
    /// Fukui.xaml の相互作用ロジック
    /// </summary>
    public partial class Fukui : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Fukui()
        {
            InitializeComponent();
        }

        private void btIshikawa_Click(object sender, RoutedEventArgs e)
        {
            var ishikawa = new Ishikawa();
            NavigationService.Navigate(ishikawa);
        }

        private void btGifu_Click(object sender, RoutedEventArgs e)
        {
            var gifu = new Gifu();
            NavigationService.Navigate(gifu);
        }

        private void btSiga_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btKyouto_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("fukui", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("fukui", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

    }
}
