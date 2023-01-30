using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
using Image = System.Windows.Controls.Image;

namespace LodgingSearchSystem
{
    /// <summary>
    /// hotelShow.xaml の相互作用ロジック
    /// </summary>
    public partial class HotelShow : Page
    {
        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        string pref = "";
        string code = "";
        string area = "";

        int min = 1;
        int max = 10;

        int next = 1;
        int back = 0;
        WebClient wc;
        public string hotelname;


        public HotelShow(string pref, string code, string area)
        {
            InitializeComponent();
            this.pref = pref;
            this.code = code;
            this.area = area;
        }



        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            string regionnum = string.Format(
                "https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=json&largeClassCode=japan&middleClassCode={0}&smallClassCode={1}&applicationId=1023910507139864215", pref, code);
            var dString1 = wc.DownloadString(regionnum);
            var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);

            //レコードの数
            var recordcount = json1.pagingInfo.recordCount;
            //表示しているレコードの番号
            var displayfirst = min;
            var displaylast = max;
            //ホテルの写真
            Image[] images = { imHotel1, imHotel2, imHotel3, imHotel4, imHotel5, imHotel6, imHotel7, imHotel8, imHotel9, imHotel10 };
            //アクセス
            TextBlock[] labelAccessArray = { textblock1, textblock2, textblock3, textblock4, textblock5, textblock6, textblock7, textblock8, textblock9, textblock10 };
            //ホテルの名前
            Label[] hotelName = { lbHotelName1, lbHotelName2, lbHotelName3, lbHotelName4, lbHotelName5, lbHotelName6, lbHotelName7, lbHotelName8, lbHotelName9, lbHotelName10 };
            //評価の数字
            Label[] serviseaverage = {lbServiceAverage1,lbServiceAverage2,lbServiceAverage3,lbServiceAverage4,lbServiceAverage5,lbServiceAverage6,lbServiceAverage7,lbServiceAverage8
                                        ,lbServiceAverage9,lbServiceAverage10};
            //星の画像
            Image[] image1 = { im10, im11, im12, im13, im14, im15, im16, im17, im18, im19 };
            Image[] image2 = { im20, im21, im22, im23, im24, im25, im26, im27, im28, im29 };
            Image[] image3 = { im30, im31, im32, im33, im34, im35, im36, im37, im38, im39 };
            Image[] image4 = { im40, im41, im42, im43, im44, im45, im46, im47, im48, im49 };
            Image[] image5 = { im50, im51, im52, im53, im54, im55, im56, im57, im58, im59 };
            //ホテル詳細
            Label[] hotelspecial = {lbHotelSpecial1,lbHotelSpecial2,lbHotelSpecial3,lbHotelSpecial4,lbHotelSpecial5,lbHotelSpecial6,lbHotelSpecial7,lbHotelSpecial8
                                            ,lbHotelSpecial9,lbHotelSpecial10};
            //郵便番号
            Label[] postalcode = { lbPostalCode1, lbPostalCode2, lbPostalCode3, lbPostalCode4, lbPostalCode5, lbPostalCode6, lbPostalCode7, lbPostalCode8, lbPostalCode9, lbPostalCode10 };
            //住所 
            Label[] address = { lbaddress1, lbaddress2, lbaddress3, lbaddress4, lbaddress5, lbaddress6, lbaddress7, lbaddress8, lbaddress9, lbaddress10 };
            //最低代金
            Label[] mincharge = { lbMinCharge1, lbMinCharge2, lbMinCharge3, lbMinCharge4, lbMinCharge5, lbMinCharge6, lbMinCharge7, lbMinCharge8, lbMinCharge9, lbMinCharge10 };

            //ホテルの写真
            for (int i = min-1*next; i < max; i++)
            {
                var imageurl = json1.hotels[i].hotel[0].hotelBasicInfo.hotelImageUrl;
                BitmapImage imagesourse = new BitmapImage(new Uri(imageurl));
                images[i].Source = imagesourse;
                labelAccessArray[i].Text = json1.hotels[i].hotel[0].hotelBasicInfo.access;
                hotelName[i].Content = json1.hotels[i].hotel[0].hotelBasicInfo.hotelName;
                serviseaverage[i].Content = json1.hotels[i].hotel[1].hotelRatingInfo.serviceAverage;
                hotelspecial[i].Content = json1.hotels[i].hotel[0].hotelBasicInfo.hotelSpecial;
                postalcode[i].Content = "〒" + json1.hotels[i].hotel[0].hotelBasicInfo.postalCode;
                mincharge[i].Content = String.Format("{0:N0}円～", json1.hotels[i].hotel[0].hotelBasicInfo.hotelMinCharge);

                string address1 = json1.hotels[i].hotel[0].hotelBasicInfo.address1;
                string address2 = json1.hotels[i].hotel[0].hotelBasicInfo.address2;
                address[i].Content = String.Format("{0}{1}", address1, address2);

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
            lbPrefName.Content = area + "　ホテル・旅館";
            lbRecordCount.Content = String.Format("{0}件中", recordcount);
            lbDisplay.Content = String.Format("{0}～{1}表示", displayfirst, displaylast);
        }

        private void btMap_Click(object sender, RoutedEventArgs e)
        {
            Map map = new Map(pref, code);
            map.Show();
        }

       
        private void btNext_Click(object sender, RoutedEventArgs e)
        {
            next++;
            min += 10; max += 10;

        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btRecommend_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
