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
        int next = 0;

        public Map(string pref,string code,int su,int next)
        {
            InitializeComponent();
            this.pref = pref;
            this.code = code;
            this.su = su;
            this.next = next;
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

            string regionnum = string.Format(
                "https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=json&largeClassCode=japan&middleClassCode={0}&smallClassCode={1}&applicationId=1023910507139864215", pref, code);
            var dString1 = wc.DownloadString(regionnum);
            var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);

            var hotelmap = json1.hotels[su].hotel[0].hotelBasicInfo.hotelMapImageUrl;
            BitmapImage imagesourse = new BitmapImage(new Uri(hotelmap));
            imHotel.Source = imagesourse;
        }
    }
}
