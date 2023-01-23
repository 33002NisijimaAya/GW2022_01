using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Collections;
using System.IO;

namespace LodgingSearchSystem {
    /// <summary>
    /// Japan.xaml の相互作用ロジック
    /// </summary>
    public partial class Japan : Page {

        public Japan() {
            InitializeComponent();   
        }

        private void btHokkaido_Click(object sender, RoutedEventArgs e) {
            var hokkaido = new Hokkaido();
            NavigationService.Navigate(hokkaido);
        }

       
        private void btAomori_Click(object sender, RoutedEventArgs e) {
            var Aomori = new Aomori();
            NavigationService.Navigate(Aomori);
        }

        private void btIwate_Click(object sender, RoutedEventArgs e)
        {
            var Iwate = new Iwate();
            NavigationService.Navigate(Iwate);
        }

        private void btFukusima_Click(object sender, RoutedEventArgs e)
        {
            var Fukusima = new Fukusima();
            NavigationService.Navigate(Fukusima);
        }

        private void btGunma_Click(object sender, RoutedEventArgs e)
        {
            var Gunma = new Gunma();
            NavigationService.Navigate(Gunma);
        }

        private void btMiyagi_Click(object sender, RoutedEventArgs e)
        {
            var Miyagi = new Miyagi();
            NavigationService.Navigate(Miyagi);
        }

        private void btAkita_Click(object sender, RoutedEventArgs e)
        {
            var Akita = new Akita();
            NavigationService.Navigate(Akita);
        }

        private void btYamagata_Click(object sender, RoutedEventArgs e)
        {
            var Yamagata = new Yamagata();
            NavigationService.Navigate(Yamagata);
        }

        private void btNigata_Click(object sender, RoutedEventArgs e)
        {
            var nigata = new Nigata();
            NavigationService.Navigate(nigata);
        }

        private void btTotigi_Click(object sender, RoutedEventArgs e)
        {
            var totigi = new Totigi();
            NavigationService.Navigate(totigi);
        }

        private void btIbaraki_Click(object sender, RoutedEventArgs e)
        {
            var ibaraki = new Ibaraki();
            NavigationService.Navigate(ibaraki);
        }

        private void btSaitama_Click(object sender, RoutedEventArgs e)
        {
            var saitama = new Saitama();
            NavigationService.Navigate(saitama);
        }
    }
}
