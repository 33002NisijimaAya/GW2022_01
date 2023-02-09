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
    /// Map2.xaml の相互作用ロジック
    /// </summary>
    public partial class Map2 : Window
    {

        string pref = "";
        string code = "";
        string detailcode = "";
        int su;

        public Map2(string pref, string code,string detailcode,int su)
        {
            InitializeComponent();
            this.pref = pref;
            this.code = code;
            this.detailcode = detailcode;
            this.su = su;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            string regionnum = string.Format(
                "https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=json&largeClassCode=japan&middleClassCode={0}&smallClassCode={1}&detailClassCode={2}&applicationId=1023910507139864215", pref, code, detailcode);
            var dString1 = wc.DownloadString(regionnum);
            var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);

            var hotelmap = json1.hotels[su].hotel[0].hotelBasicInfo.hotelMapImageUrl;
            BitmapImage imagesourse = new BitmapImage(new Uri(hotelmap));
            imHotel.Source = imagesourse;
        }
    }
}
