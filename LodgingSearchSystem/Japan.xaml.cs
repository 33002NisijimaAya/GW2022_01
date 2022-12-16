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

        private void cbRegion_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            cbPrefecture.Items.Clear();
            if (cbRegion.SelectedItem.ToString() == "北海道") {
                cbPrefecture.Items.Add("北海道");
            } else if (cbRegion.SelectedItem.ToString() == "東北") {
                cbPrefecture.Items.Add("青森県"); cbPrefecture.Items.Add("岩手県");
                cbPrefecture.Items.Add("宮城県"); cbPrefecture.Items.Add("秋田県");
                cbPrefecture.Items.Add("山形県"); cbPrefecture.Items.Add("福島県");
            } else if (cbRegion.SelectedItem.ToString() == "北関東") {
                cbPrefecture.Items.Add("茨城県");cbPrefecture.Items.Add("栃木県");
                cbPrefecture.Items.Add("群馬県");
            } else if (cbRegion.SelectedItem.ToString() == "首都圏") {
                cbPrefecture.Items.Add("埼玉県"); cbPrefecture.Items.Add("千葉県");
                cbPrefecture.Items.Add("東京都"); cbPrefecture.Items.Add("神奈川県");
            } else if (cbRegion.SelectedItem.ToString() == "甲信越") {
                cbPrefecture.Items.Add("新潟県"); cbPrefecture.Items.Add("長野県");
                cbPrefecture.Items.Add("山梨県");
            } else if (cbRegion.SelectedItem.ToString() == "東海") {
                cbPrefecture.Items.Add("静岡県"); cbPrefecture.Items.Add("愛知県");
                cbPrefecture.Items.Add("岐阜県"); cbPrefecture.Items.Add("三重県");
            } else if (cbRegion.SelectedItem.ToString() == "伊豆・箱根") {
                cbPrefecture.Items.Add("伊豆・箱根");
            } else if (cbRegion.SelectedItem.ToString() == "北陸") {
                cbPrefecture.Items.Add("富山県"); cbPrefecture.Items.Add("石川県");
                cbPrefecture.Items.Add("福井県");
            } else if (cbRegion.SelectedItem.ToString() == "近畿") {
                cbPrefecture.Items.Add("滋賀県"); cbPrefecture.Items.Add("京都府"); cbPrefecture.Items.Add("大阪府");
                cbPrefecture.Items.Add("兵庫県"); cbPrefecture.Items.Add("奈良県"); cbPrefecture.Items.Add("和歌山県");
            } else if (cbRegion.SelectedItem.ToString() == "山陽・山陰") {
                cbPrefecture.Items.Add("鳥取県"); cbPrefecture.Items.Add("島根県"); cbPrefecture.Items.Add("岡山県");
                cbPrefecture.Items.Add("広島県"); cbPrefecture.Items.Add("山口県");
            } else if (cbRegion.SelectedItem.ToString() == "九州") {
                cbPrefecture.Items.Add("福岡県"); cbPrefecture.Items.Add("佐賀県"); cbPrefecture.Items.Add("長崎県");
                cbPrefecture.Items.Add("熊本県"); cbPrefecture.Items.Add("大分県"); cbPrefecture.Items.Add("宮崎県");
                cbPrefecture.Items.Add("鹿児島県");
            } else if (cbRegion.SelectedItem.ToString() == "四国") {
                cbPrefecture.Items.Add("徳島県");
                cbPrefecture.Items.Add("香川県");
                cbPrefecture.Items.Add("愛媛県");
                cbPrefecture.Items.Add("高知県");
            } else if (cbRegion.SelectedItem.ToString() == "沖縄") {
                cbPrefecture.Items.Add("沖縄");
            }
        }

        private void cbRegion_Loaded(object sender, RoutedEventArgs e) {
            cbRegion.ItemsSource = new string[] {
                "北海道","東北","北関東","首都圏","甲信越","東海","伊豆・箱根","北陸","近畿","山陽・山陰","九州","四国","沖縄"
            };
        }

        private void btGet_Click(object sender, RoutedEventArgs e) {
            if (cbPrefecture.Text == "北海道") {
                var hokkaido = new Hokkaido();
                NavigationService.Navigate(hokkaido);
            }else if(cbPrefecture.Text == "青森県") {
                var Aomori = new Aomori();
                NavigationService.Navigate(Aomori);
            }
        }

        private void btAomori_Click(object sender, RoutedEventArgs e) {
            var Aomori = new Aomori();
            NavigationService.Navigate(Aomori);
        }
    }
}
