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

        private void btTiba_Click(object sender, RoutedEventArgs e)
        {
            var tiba = new Tiba();
            NavigationService.Navigate(tiba);
        }

        private void btTokyo_Click(object sender, RoutedEventArgs e)
        {
            var tokyo = new Tokyo();
            NavigationService.Navigate(tokyo);
        }

        private void btKanagawa_Click(object sender, RoutedEventArgs e)
        {
            var kanagawa = new Kanagawa();
            NavigationService.Navigate(kanagawa);
        }

        private void btYamanasi_Click(object sender, RoutedEventArgs e)
        {
            var yamanasi = new Yamanasi();
            NavigationService.Navigate(yamanasi);
        }

        private void btNagano_Click(object sender, RoutedEventArgs e)
        {
            var nagano = new Nagano();
            NavigationService.Navigate(nagano);
        }

        private void btToyama_Click(object sender, RoutedEventArgs e)
        {
            var toyama = new Toyama();
            NavigationService.Navigate(toyama);
        }

        private void btSizuoka_Click(object sender, RoutedEventArgs e)
        {
            var shizuoka = new Shizuoka();
            NavigationService.Navigate(shizuoka);
        }

        private void btIshikawa_Click(object sender, RoutedEventArgs e)
        {
            var ishikawa = new Ishikawa();
            NavigationService.Navigate(ishikawa);
        }

        private void btFukui_Click(object sender, RoutedEventArgs e)
        {
            var fukui = new Fukui();
            NavigationService.Navigate(fukui);
        }

        private void btGifu_Click(object sender, RoutedEventArgs e)
        {
            var gifu = new Gifu();
            NavigationService.Navigate(gifu);
        }

        private void btAiti_Click(object sender, RoutedEventArgs e)
        {
            var aiti = new Aiti();
            NavigationService.Navigate(aiti);
        }

        private void btMie_Click(object sender, RoutedEventArgs e)
        {
            var mie = new Mie();
            NavigationService.Navigate(mie);
        }

        private void btSiga_Click(object sender, RoutedEventArgs e)
        {
            var siga = new Siga();
            NavigationService.Navigate(siga);
        }

        private void btKyoto_Click(object sender, RoutedEventArgs e)
        {
            var kyoto = new Kyoto();
            NavigationService.Navigate(kyoto);
        }

        private void btOsaka_Click(object sender, RoutedEventArgs e)
        {
            var osaka = new Osaka();
            NavigationService.Navigate(osaka);
        }

        private void btWakayama_Click(object sender, RoutedEventArgs e)
        {
            var wakayama = new Wakayama();
            NavigationService.Navigate(wakayama);
        }

        private void btHyogo_Click(object sender, RoutedEventArgs e)
        {
            var hyogo = new Hyogo();
            NavigationService.Navigate(hyogo);
        }

        private void btTottori_Click(object sender, RoutedEventArgs e)
        {
            var tottori = new Tottori();
            NavigationService.Navigate(tottori);
        }

        private void btOkayama_Click(object sender, RoutedEventArgs e)
        {
            var okayama = new Okayama();
            NavigationService.Navigate(okayama);
        }

        private void btSimane_Click(object sender, RoutedEventArgs e)
        {
            var shimane = new Simane();
            NavigationService.Navigate(shimane);
        }

        private void btHirosima_Click(object sender, RoutedEventArgs e)
        {
            var hirosima = new Hirosima();
            NavigationService.Navigate(hirosima);
        }

        private void btYamaguti_Click(object sender, RoutedEventArgs e)
        {
            var yamaguti = new Yamaguti();
            NavigationService.Navigate(yamaguti);
        }

        private void btKagawa_Click(object sender, RoutedEventArgs e)
        {
            var kagawa = new Kagawa();
            NavigationService.Navigate(kagawa);
        }

        private void btTokushima_Click(object sender, RoutedEventArgs e)
        {
            var tokushima = new Tokusima();
            NavigationService.Navigate(tokushima);
        }

        private void btKouti_Click(object sender, RoutedEventArgs e)
        {
            var kouti = new Kouti();
            NavigationService.Navigate(kouti);
        }

        private void btEhime_Click(object sender, RoutedEventArgs e)
        {
            var ehime = new Ehime();
            NavigationService.Navigate(ehime);
        }

        private void btFukuoka_Click(object sender, RoutedEventArgs e)
        {
            var fukuoka = new Fukuoka();
            NavigationService.Navigate(fukuoka);
        }

        private void btOita_Click(object sender, RoutedEventArgs e)
        {
            var oita = new Oita();
            NavigationService.Navigate(oita);
        }

        private void btKumamoto_Click(object sender, RoutedEventArgs e)
        {
            var kumamoto = new Kumamoto();
            NavigationService.Navigate(kumamoto);
        }

        private void btMiyazaki_Click(object sender, RoutedEventArgs e)
        {
            var miyazaki = new Miyazaki();
            NavigationService.Navigate(miyazaki);
        }

        private void btSaga_Click(object sender, RoutedEventArgs e)
        {
            var saga = new Saga();
            NavigationService.Navigate(saga);
        }

        private void btKagosima_Click(object sender, RoutedEventArgs e)
        {
            var kagosima = new Kagosima();
            NavigationService.Navigate(kagosima);
        }

        private void btNagasaki_Click(object sender, RoutedEventArgs e)
        {
            var nagasaki = new Nagasaki();
            NavigationService.Navigate(nagasaki);
        }

        private void btOkinawa_Click(object sender, RoutedEventArgs e)
        {
            var okinawa = new Okinawa();
            NavigationService.Navigate(okinawa);
        }

        private void btNara_Click(object sender, RoutedEventArgs e)
        {
            var nara = new Nara();
            NavigationService.Navigate(nara);
        }
    }
}
