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


        private void btMap_Click(object sender, RoutedEventArgs e)
        {
            Map2 map = new Map2(pref, code,detailcode);
            map.Show();
        }

        private void btRecommend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (area == "札幌・新札幌・琴似")
            {
                detailcode = "A";
            }
            else if (area == "大通公園・時計台・狸小路")
            {
                detailcode = "B";
            }
            else
            {
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
            else if (area == "赤坂・六本木・霞ヶ関・永田町")
            {
                detailcode = "C";
            }
            else if (area == "渋谷・恵比寿・目黒・二子玉川")
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
            else if (area == "栄・錦・名古屋城")
            {
                detailcode = "B";
            }
            else if (area == "金山・熱田・千種・ナゴヤドーム")
            {
                detailcode = "C";
            }

            if (pref == "osaka" && code == "shi")
            {
                if (area == "大阪駅・梅田・ユニバーサルシティ・尼崎")
                {
                    detailcode = "B";
                }
                else if (area == "なんば・心斎橋・天王寺・阿倍野・長居")
                {
                    detailcode = "D";
                }
                else if (area == "京橋・淀屋橋・本町・ベイエリア・弁天町")
                {
                    detailcode = "C";
                }
                else
                {
                    detailcode = "A";
                }
            }

            if (pref == "kyoto" && code == "shi")
            {
                if (area == "京都駅")
                {
                    detailcode = "D";
                }
                else if (area == "嵐山・嵯峨野・太秦・高雄")
                {
                    detailcode = "A";
                }
                else if (area == "河原町・四条烏丸・二条城・御所")
                {
                    detailcode = "B";
                }
                else if (area == "祇園・東山・北白川")
                {
                    detailcode = "C";
                }
                else if (area == "大原・鞍馬・貴船")
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

            //ホテルの写真
            Image[] images = { imHotel1, imHotel2, imHotel3, imHotel4, imHotel5, imHotel6, imHotel7, imHotel8, imHotel9, imHotel10 };
            for (int i = 0; i < images.Length; i++)
            {
                var imageurl = json1.hotels[i].hotel[0].hotelBasicInfo.hotelImageUrl;
                BitmapImage imagesourse = new BitmapImage(new Uri(imageurl));
                images[i].Source = imagesourse;
            }

            //アクセス
            TextBlock[] labelAccessArray = { textblock1, textblock2, textblock3, textblock4, textblock5, textblock6, textblock7, textblock8, textblock9, textblock10 };
            for (int i = 0; i < labelAccessArray.Length; i++)
            {
                labelAccessArray[i].Text = json1.hotels[i].hotel[0].hotelBasicInfo.access;
            }

            //ホテルの名前
            Label[] hotelName = { lbHotelName1, lbHotelName2, lbHotelName3, lbHotelName4, lbHotelName5, lbHotelName6, lbHotelName7, lbHotelName8, lbHotelName9, lbHotelName10 };
            for (int i = 0; i < hotelName.Length; i++)
            {
                hotelName[i].Content = json1.hotels[i].hotel[0].hotelBasicInfo.hotelName;
            }

            //評価の数字
            Label[] serviseaverage = {lbServiceAverage1,lbServiceAverage2,lbServiceAverage3,lbServiceAverage4,lbServiceAverage5,lbServiceAverage6,lbServiceAverage7,lbServiceAverage8
                                        ,lbServiceAverage9,lbServiceAverage10};
            for (int i = 0; i < serviseaverage.Length; i++)
            {
                serviseaverage[i].Content = json1.hotels[i].hotel[1].hotelRatingInfo.serviceAverage;

            }

            Image[] image1 = { im10, im11, im12, im13, im14, im15, im16, im17, im18, im19 };
            Image[] image2 = { im20, im21, im22, im23, im24, im25, im26, im27, im28, im29 };
            Image[] image3 = { im30, im31, im32, im33, im34, im35, im36, im37, im38, im39 };
            Image[] image4 = { im40, im41, im42, im43, im44, im45, im46, im47, im48, im49 };
            Image[] image5 = { im50, im51, im52, im53, im54, im55, im56, im57, im58, im59 };


            for (int i = 0; i < image1.Length; i++)
            {

                int ser = Convert.ToInt32(serviseaverage[i].Content);

                if (ser >= 5)
                {
                    ;
                }
                else if (ser >= 3.8)
                {
                    image5[i].Source = null;
                }
                else if (ser >= 2.8)
                {
                    image5[i].Source = null;
                    image4[i].Source = null;
                }
                else if (ser >= 1.8)
                {
                    image5[i].Source = null;
                    image4[i].Source = null;
                    image3[i].Source = null;
                }
                else if (ser >= 1)
                {
                    image5[i].Source = null;
                    image4[i].Source = null;
                    image3[i].Source = null;
                    image2[i].Source = null;
                }
                else
                {
                    image5[i].Source = null;
                    image4[i].Source = null;
                    image3[i].Source = null;
                    image2[i].Source = null;
                    image1[i].Source = null;
                }
            }

            //ホテル詳細
            Label[] hotelspecial = {lbHotelSpecial1,lbHotelSpecial2,lbHotelSpecial3,lbHotelSpecial4,lbHotelSpecial5,lbHotelSpecial6,lbHotelSpecial7,lbHotelSpecial8
                                            ,lbHotelSpecial9,lbHotelSpecial10};
            for (int i = 0; i < hotelspecial.Length; i++)
            {
                hotelspecial[i].Content = json1.hotels[i].hotel[0].hotelBasicInfo.hotelSpecial;
            }

            //郵便番号
            Label[] postalcode = { lbPostalCode1, lbPostalCode2, lbPostalCode3, lbPostalCode4, lbPostalCode5, lbPostalCode6, lbPostalCode7, lbPostalCode8, lbPostalCode9, lbPostalCode10 };
            for (int i = 0; i < postalcode.Length; i++)
            {
                postalcode[i].Content = "〒" + json1.hotels[i].hotel[0].hotelBasicInfo.postalCode;
            }

            //住所 
            Label[] address = { lbaddress1, lbaddress2, lbaddress3, lbaddress4, lbaddress5, lbaddress6, lbaddress7, lbaddress8, lbaddress9, lbaddress10 };
            for (int i = 0; i < address.Length; i++)
            {
                string address1 = json1.hotels[i].hotel[0].hotelBasicInfo.address1;
                string address2 = json1.hotels[i].hotel[0].hotelBasicInfo.address2;
                address[i].Content = String.Format("{0}{1}", address1, address2);
            }

            //最低代金
            //var mincharge = json1.hotels[0].hotel[0].hotelBasicInfo.hotelMinCharge;
            Label[] mincharge = { lbMinCharge1, lbMinCharge2, lbMinCharge3, lbMinCharge4, lbMinCharge5, lbMinCharge6, lbMinCharge7, lbMinCharge8, lbMinCharge9, lbMinCharge10 };
            for (int i = 0; i < mincharge.Length; i++)
            {
                mincharge[i].Content = String.Format("{0:N0}円～", json1.hotels[i].hotel[0].hotelBasicInfo.hotelMinCharge);
            }

            lbPrefName.Content = area + "　ホテル・旅館";
            lbRecordCount.Content = String.Format("{0}件中", recordcount);
            lbDisplay.Content = String.Format("{0}～{1}表示", displayfirst, displaylast);
        }

        private void btMap1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
