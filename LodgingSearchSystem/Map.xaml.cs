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
using System.Windows.Shapes;

namespace LodgingSearchSystem
{
    /// <summary>
    /// Map.xaml の相互作用ロジック
    /// </summary>
    public partial class Map : Window
    {

        string pref = "";
        string code = "";
        int su = 0;
        int page;
        string sort;
        string optionStr;
        Rootobject json;

        public Map(string pref,string code,int su,int page,string sort,string optionStr)
        {
            InitializeComponent();
            this.pref = pref;
            this.code = code;
            this.su = su;
            this.page = page;
            this.sort = sort;
            this.optionStr = optionStr;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            //switch (next)
            //{
            //    case 1:
            //        next += 10;
            //        return;
            //    case 2:
            //        next += 20;
            //        return;
            //    case 3:
            //        next += 30;
            //        return;
            //    default:
            //        return;
            //}

          

            if (sort != null && optionStr == "")
            {
                string regionnum2 = string.Format(
                        "https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=json&largeClassCode=japan&middleClassCode={0}&smallClassCode={1}&page={2}&sort={3}&applicationId=1023910507139864215", pref, code, page, sort);
                var dString2 = wc.DownloadString(regionnum2);
                var json2 = JsonConvert.DeserializeObject<Rootobject>(dString2);
                json = json2;
            }
            else if (sort == null && optionStr != "")
            {
                try
                {
                    string regionnum3 = string.Format(
                        "https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=json&largeClassCode=japan&middleClassCode={0}&smallClassCode={1}&page={2}&squeezeCondition={3}&applicationId=1023910507139864215", pref, code, page,optionStr);
                    var dString3 = wc.DownloadString(regionnum3);
                    var json3 = JsonConvert.DeserializeObject<Rootobject>(dString3);
                    json = json3;
                }
                catch (System.Net.WebException ex)
                {
                    MessageBox.Show("該当ホテル・旅館がありません。");
                }
            }
            else if (sort != null && optionStr != "")
            {
                try
                {
                    string regionnum4 = string.Format(
                         "https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=json&largeClassCode=japan&middleClassCode={0}&smallClassCode={1}&page={2}&sort={3}&squeezeCondition={4}&applicationId=1023910507139864215", pref, code, page, sort, optionStr);
                    var dString4 = wc.DownloadString(regionnum4);
                    var json4 = JsonConvert.DeserializeObject<Rootobject>(dString4);
                    json = json4;
                }
                catch (WebException ex)
                {
                    MessageBox.Show("該当ホテル・旅館がありません。");
                }
            }
            else
            {
                string regionnum1 = string.Format(
                                  "https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=json&largeClassCode=japan&middleClassCode={0}&smallClassCode={1}&page={2}&applicationId=1023910507139864215", pref, code, page);
                var dString1 = wc.DownloadString(regionnum1);
                var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
                json = json1;

            }

            var hotelmap = json.hotels[su].hotel[0].hotelBasicInfo.hotelMapImageUrl;
            BitmapImage imagesourse = new BitmapImage(new Uri(hotelmap));
            imHotel.Source = imagesourse;
        }

    }
}
