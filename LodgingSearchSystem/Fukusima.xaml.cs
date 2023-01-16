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
    /// Fukusima.xaml の相互作用ロジック
    /// </summary>
    public partial class Fukusima : Page
    {
        public Fukusima()
        {
            InitializeComponent();
        }

        private void btHome_Click(object sender, RoutedEventArgs e)
        {
            var japan = new Japan();
            NavigationService.Navigate(japan);
        }

        private void btYamagata_Click(object sender, RoutedEventArgs e)
        {
            var Yamagata = new Yamagata();
            NavigationService.Navigate(Yamagata);
        }

        private void btMiyagi_Click(object sender, RoutedEventArgs e)
        {
            var Miyagi = new Miyagi();
            NavigationService.Navigate(Miyagi);
        }

        private void btNigata_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
