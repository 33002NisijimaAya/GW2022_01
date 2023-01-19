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

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };



            string json = string.Format("https://app.rakuten.co.jp/services/api/Travel/GetAreaClass/20131024?format=json&applicationId=1089830036510088330");
           

            var dString1 = wc.DownloadString(json);

            var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
            var name = json1.areaClasses.largeClasses[0].largeClass[0].largeClassName;
            
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Akita = new Akita();
            NavigationService.Navigate(Akita);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Yamagata = new Yamagata();
            NavigationService.Navigate(Yamagata);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var Miyagi = new Miyagi();
            NavigationService.Navigate(Miyagi);
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
    }
}
