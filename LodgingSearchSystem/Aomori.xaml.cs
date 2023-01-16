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
    /// Aomori.xaml の相互作用ロジック
    /// </summary>
    public partial class Aomori : Page
    {
        public string middleClassName;
        public string smallClassName;
        public string detailClassName;
        public Aomori()
        {
            InitializeComponent();
        }

        
        private void btAkita_Click(object sender, RoutedEventArgs e)
        {
            var Akita = new Akita();
            NavigationService.Navigate(Akita);
        }

        private void btIwate_Click(object sender, RoutedEventArgs e)
        {
            var Iwate = new Iwate();
            NavigationService.Navigate(Iwate);
        }

        private void btHokkaido_Click(object sender, RoutedEventArgs e)
        {
            var Hokkaido = new Hokkaido();
            NavigationService.Navigate(Hokkaido);
        }

        private void btHome_Click(object sender, RoutedEventArgs e)
        {
            var japan = new Japan();
            NavigationService.Navigate(japan);
        }

        private void btAomori_Click(object sender, RoutedEventArgs e)
        {
            var Hotelshow = new HotelShow();
            NavigationService.Navigate(Hotelshow);
        }

        private void btOma_Click(object sender, RoutedEventArgs e)
        {
            var Hotelshow = new HotelShow();
            Hotelshow.hotelname = btOma.ToolTip.ToString();
            NavigationService.Navigate(Hotelshow);
        }

        
    }
}
