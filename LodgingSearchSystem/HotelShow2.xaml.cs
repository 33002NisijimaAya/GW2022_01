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

namespace LodgingSearchSystem
{
    /// <summary>
    /// HotelShow2.xaml の相互作用ロジック
    /// </summary>
    public partial class HotelShow2 : Page
    {

        string pref = "";
        string code = "";
        string area = "";
        string detailcode = "";

        public HotelShow2(string pref, string code, string area)
        {
            InitializeComponent();
            this.pref = pref;
            this.area = area;
            this.code = code;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            if (area == "札幌・新札幌・琴似"){
                detailcode = "A";
            }else if (area == "大通公園・時計台・狸小路"){
                detailcode = "B";
            }else{
                detailcode = "C";
            }

            if (area == "東京駅・銀座・秋葉原・東陽町・葛西")
            {
                detailcode = "A";
            }
            else if (area == "新橋・汐留・浜松町・お台場")
            {
                detailcode = "B";
            }
            else if(area == "赤坂・六本木・霞ヶ関・永田町")
            {
                detailcode = "C";
            }
            else if(area == "渋谷・恵比寿・目黒・二子玉川")
            {
                detailcode = "D";
            }
            else if (area == "品川・大井町・蒲田・羽田空港")
            {
                detailcode = "E";
            }
            else if (area == "新宿・中野・荻窪・四谷")
            {
                detailcode = "F";
            }
            else if (area == "池袋・赤羽・巣鴨・大塚")
            {
                detailcode = "G";
            }
            else if (area == "東京ドーム・飯田橋・御茶ノ水")
            {
                detailcode = "H";
            }
            else if (area == "上野・浅草・錦糸町・新小岩・北千住")
            {
                detailcode = "I";
            }

            if (area == "名古屋駅・伏見・丸の内")
            {
                detailcode = "A";
            }
            else if(area == "栄・錦・名古屋城")
            {
                detailcode = "B";
            }
            else if (area == "金山・熱田・千種・ナゴヤドーム")
            {
                detailcode = "C";
            }

            if (pref == "osaka" && code == "shi")
            {
                if(area== "大阪駅・梅田・ユニバーサルシティ・尼崎")
                {
                    detailcode = "B";
                }else if(area == "なんば・心斎橋・天王寺・阿倍野・長居")
                {
                    detailcode = "D";
                }else if(area == "京橋・淀屋橋・本町・ベイエリア・弁天町")
                {
                    detailcode = "C";
                }
                else
                {
                    detailcode = "A";
                }
            }

            if(pref == "kyoto" && code == "shi")
            {
                if(area == "京都駅")
                {
                    detailcode = "D";
                }else if(area == "嵐山・嵯峨野・太秦・高雄")
                {
                    detailcode = "A";
                }else if(area == "河原町・四条烏丸・二条城・御所")
                {
                    detailcode = "B";
                }else if(area == "祇園・東山・北白川")
                {
                    detailcode = "C";
                }else if(area == "大原・鞍馬・貴船")
                {
                    detailcode = "E";
                }

            }

            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            string regionnum = string.Format(
                "https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=json&largeClassCode=japan&middleClassCode={0}&smallClassCode={1}&detailClassCode={2}&applicationId=1023910507139864215", pref, code, detailcode);
            var dString1 = wc.DownloadString(regionnum);
            var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);

            //レコードの数
            var recordcount = json1.pagingInfo.recordCount;
            //表示しているレコードの番号
            var displayfirst = json1.pagingInfo.first;
            var displaylast = json1.pagingInfo.last;
            //ホテルの名前
            var hotelname = json1.hotels[0].hotel[0].hotelBasicInfo.hotelName;
            //評価の数字
            var serviceaverage = json1.hotels[0].hotel[1].hotelRatingInfo.serviceAverage;
            //ホテル詳細
            var hotelspecial = json1.hotels[0].hotel[0].hotelBasicInfo.hotelSpecial;
            //郵便番号
            var postalcode = json1.hotels[0].hotel[0].hotelBasicInfo.postalCode;
            //住所
            var address1 = json1.hotels[0].hotel[0].hotelBasicInfo.address1;
            var address2 = json1.hotels[0].hotel[0].hotelBasicInfo.address2;
            //アクセス
            var access = json1.hotels[0].hotel[0].hotelBasicInfo.access;
            //最低代金
            var mincharge = json1.hotels[0].hotel[0].hotelBasicInfo.hotelMinCharge;
            //ホテルの写真
            var imageurl = json1.hotels[0].hotel[0].hotelBasicInfo.hotelImageUrl;
            BitmapImage imagesourse = new BitmapImage(new Uri(imageurl));
            imHotel.Source = imagesourse;


            lbPrefName.Content = area + "　ホテル・旅館";
            lbRecordCount.Content = String.Format("{0}件中", recordcount);
            lbDisplay.Content = String.Format("{0}～{1}表示", displayfirst, displaylast);
            lbHotelName.Content = hotelname;
            lbServiceAverage.Content = serviceaverage;
            lbHotelSpecial.Content = hotelspecial;
            lbPostalCode.Content = String.Format("〒{0}", postalcode);
            lbaddress.Content = String.Format("{0}{1}", address1, address2);
            lbaccess.Content = access;
            lbMinCharge.Content = String.Format("{0:N0}円～", mincharge);


            if (serviceaverage >= 5)
            {
                ;
            }
            else if (serviceaverage >= 3.8)
            {
                im5.Source = null;
            }
            else if (serviceaverage >= 2.8)
            {
                im5.Source = null;
                im4.Source = null;
            }
            else if (serviceaverage >= 1.8)
            {
                im5.Source = null;
                im4.Source = null;
                im3.Source = null;
            }
            else if (serviceaverage >= 1)
            {
                im5.Source = null;
                im4.Source = null;
                im3.Source = null;
                im2.Source = null;
            }
            else
            {
                im5.Source = null;
                im4.Source = null;
                im3.Source = null;
                im2.Source = null;
                im1.Source = null;
            }
        }

        private void btMap_Click(object sender, RoutedEventArgs e)
        {
            Map map = new Map(pref, code);
            map.Show();
        }

    }
}
