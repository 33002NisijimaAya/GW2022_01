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

        int min = 0;
        int max = 9;
        int recordmin = 0;
        int recordmax = 9;
        int j = 0;
        int next = 0;
        int recordcount;
        int page = 1;
        string sort = null;
        Rootobject json;

        WebClient wc = new WebClient()
        {
            Encoding = Encoding.UTF8
        };

        public HotelShow(string pref, string code, string area)
        {
            InitializeComponent();
            this.pref = pref;
            this.code = code;
            this.area = area;
            btBack.IsEnabled = false;
        }



        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            CallJson(wc);
            //レコードの数
            recordcount = json.pagingInfo.recordCount;
            //表示しているレコードの番号
            var displayfirst = recordmin + 1;
            var displaylast = recordmax + 1;
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

            Button[] map = { btMap1, btMap2, btMap3, btMap4, btMap5, btMap6, btMap7, btMap8, btMap9, btMap10 };

            for (int i = min; i <= max; i++)
            {
                var imageurl = json.hotels[i].hotel[0].hotelBasicInfo.hotelImageUrl;
                BitmapImage imagesourse = new BitmapImage(new Uri(imageurl));
                images[j].Source = imagesourse;
                labelAccessArray[j].Text = json.hotels[i].hotel[0].hotelBasicInfo.access;
                hotelName[j].Content = json.hotels[i].hotel[0].hotelBasicInfo.hotelName;
                serviseaverage[j].Content = json.hotels[i].hotel[1].hotelRatingInfo.serviceAverage;
                hotelspecial[j].Content = json.hotels[i].hotel[0].hotelBasicInfo.hotelSpecial;
                postalcode[j].Content = "〒" + json.hotels[i].hotel[0].hotelBasicInfo.postalCode;
                mincharge[j].Content = String.Format("{0:N0}円～", json.hotels[i].hotel[0].hotelBasicInfo.hotelMinCharge);
                string address1 = json.hotels[i].hotel[0].hotelBasicInfo.address1;
                string address2 = json.hotels[i].hotel[0].hotelBasicInfo.address2;
                address[j].Content = String.Format("{0}{1}", address1, address2);

                int ser = Convert.ToInt32(serviseaverage[j].Content);

                if (ser >= 5)
                {
                    ;
                }
                else if (ser >= 3.8)
                {
                    image5[j].Source = null;
                }
                else if (ser >= 2.8)
                {
                    image5[j].Source = null;
                    image4[j].Source = null;
                }
                else if (ser >= 1.8)
                {
                    image5[j].Source = null;
                    image4[j].Source = null;
                    image3[j].Source = null;
                }
                else if (ser >= 1)
                {
                    image5[j].Source = null;
                    image4[j].Source = null;
                    image3[j].Source = null;
                    image2[j].Source = null;
                }
                else
                {
                    image5[j].Source = null;
                    image4[j].Source = null;
                    image3[j].Source = null;
                    image2[j].Source = null;
                    image1[j].Source = null;
                    serviseaverage[j].Content = "口コミ０件";
                }
                j++;
            }
            lbPrefName.Content = area + "　ホテル・旅館";
            lbRecordCount.Content = String.Format("{0}件中", recordcount);
            lbDisplay.Content = String.Format("{0}～{1}表示", displayfirst, displaylast);
        }

        private void CallJson(WebClient wc)
        {
            if (sort != null)
            {
                string regionnum2 = string.Format(
                        "https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=json&largeClassCode=japan&middleClassCode={0}&smallClassCode={1}&page={2}&sort={3}&applicationId=1023910507139864215", pref, code, page, sort);
                var dString2 = wc.DownloadString(regionnum2);
                var json2 = JsonConvert.DeserializeObject<Rootobject>(dString2);
                json = json2;
            }
            else
            {
                string regionnum1 = string.Format(
                        "https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=json&largeClassCode=japan&middleClassCode={0}&smallClassCode={1}&page={2}&applicationId=1023910507139864215", pref, code, page);
                var dString1 = wc.DownloadString(regionnum1);
                var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
                json = json1;
            }
        }

        private void btNext_Click(object sender, RoutedEventArgs e)
        {
            next++;
            min += 10; max += 10;
            recordmin += 10; recordmax += 10;

            if (next % 3 == 0)
            {
                page++;
                min = 0;
                max = 9;
            }

            if (recordmax >= recordcount)
            {
                if (page >= 2)
                {
                    max = min + (recordcount - (next * 10) - 1);
                }
                else
                {
                    max = recordcount - 1;
                }
                recordmax = recordcount - 1;
                btNext.IsEnabled = false;
            }

            j = 0;

            Page_Loaded(sender, e);

            btBack.IsEnabled = true;
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            btNext.IsEnabled = true;
            if (recordmax + 1 == recordcount)
            {
                max = (next * 10 + (recordcount - (next * 10))) - (recordcount - (next * 10));
                recordmax = max;
                min -= 10;
                recordmin -= 10;
            }
            else
            {
                recordmin -= 10; recordmax -= 10;
            }


            if (next % 3 == 0 && next != 0)
            {
                page--;
                min = 20;
                max = 29;
               
            }
            else if (recordmax + 1 != recordcount)
            {
                min -= 10; max -= 10;
              
            }

            next--;

            j = 0;
            Page_Loaded(sender, e);

            if (next == 0)
            {
                btBack.IsEnabled = false;
            }
        }

        private void Sort(object sender, RoutedEventArgs e)
        {
            sort = null;
            recordmin = 0;
            recordmax = 9;
            min = 0;
            max = 9;
            j = 0;
            next = 1;
            btBack.IsEnabled = false;
        }

        private void Mapshow(int i)
        {
            Map map = new Map(pref, code, i);
            map.Show();
        }

        private void btRecommend_Click(object sender, RoutedEventArgs e)
        {
            Sort(sender, e);
            sort = "standard";
            Page_Loaded(sender, e);
        }


        private void btMax_Click(object sender, RoutedEventArgs e)
        {
            Sort(sender, e);
            sort = "-roomCharge";
            Page_Loaded(sender, e);
        }

        private void btMin_Click(object sender, RoutedEventArgs e)
        {
            Sort(sender, e);
            sort = "+roomCharge";
            Page_Loaded(sender, e);
        }

        private void btMap1_Click(object sender, RoutedEventArgs e)
        {
            Mapshow(0);
        }


        private void btMap2_Click(object sender, RoutedEventArgs e)
        {
            Mapshow(1);
        }

        private void btMap3_Click(object sender, RoutedEventArgs e)
        {
            Mapshow(2);
        }

        private void btMap4_Click(object sender, RoutedEventArgs e)
        {
            Mapshow(3);
        }

        private void btMap5_Click(object sender, RoutedEventArgs e)
        {
            Mapshow(4);
        }

        private void btMap6_Click(object sender, RoutedEventArgs e)
        {
            Mapshow(5);
        }

        private void btMap7_Click(object sender, RoutedEventArgs e)
        {
            Mapshow(6);
        }

        private void btMap8_Click(object sender, RoutedEventArgs e)
        {
            Mapshow(7);
        }

        private void btMap9_Click(object sender, RoutedEventArgs e)
        {
            Mapshow(8);
        }

        private void btMap10_Click(object sender, RoutedEventArgs e)
        {
            Mapshow(9);
        }

    }
}
