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

namespace LodgingSearchSystem {
    /// <summary>
    /// Japan.xaml の相互作用ロジック
    /// </summary>
    public partial class Japan : Page {
        WebClient wc;
       
        
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

        private void cbRegion_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if(cbRegion.SelectedItem.ToString() == "北海道") {
                cbPrefecture.Items.Add("北海道");
            } else if(cbRegion.SelectedItem.ToString() == "東北"){
                cbPrefecture.Items.Add("秋田");
            }
        }

        private void cbRegion_Loaded(object sender, RoutedEventArgs e) {
            List<string> reagionarea = new List<string> {
                "東北","北関東","首都圏","甲信越","東海","伊豆・箱根","北陸","近畿","山陽・山陰","九州","四国","沖縄"
            };
            cbRegion.Items.Add(reagionarea);
        }
    }
}
