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
    /// Tottori.xaml の相互作用ロジック
    /// </summary>
    public partial class Tottori : Page
    {

        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        public Tottori()
        {
            InitializeComponent();
        }

        
        private void btArea_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            var Hotelshow = new HotelShow("tottori", parent.Areanames[(string)bt.ToolTip], (string)bt.ToolTip);
            NavigationService.Navigate(Hotelshow);
        }

        private void AreaName_Click(object sender, RoutedEventArgs s)
        {
            Button bt = (Button)sender;
            var HotelShow = new HotelShow("tottori", parent.Areanames[(string)bt.Content], (string)bt.Content);
            NavigationService.Navigate(HotelShow);
        }

        private void btHyougo_Click(object sender, RoutedEventArgs e)
        {
            var hyogo = new Hyogo();
            NavigationService.Navigate(hyogo);
        }

        private void btOkayama_Click(object sender, RoutedEventArgs e)
        {
            var okayama = new Okayama();
            NavigationService.Navigate(okayama);
        }

        private void btHirosima_Click(object sender, RoutedEventArgs e)
        {
            var hirosima = new Hirosima();
            NavigationService.Navigate(hirosima);
        }

        private void btSimane_Click(object sender, RoutedEventArgs e)
        {
            var simane = new Simane();
            NavigationService.Navigate(simane);
        }
    }
}
