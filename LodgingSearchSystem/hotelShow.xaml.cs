using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
    /// hotelShow.xaml の相互作用ロジック
    /// </summary>
    public partial class HotelShow : Page
    {
        MainWindow parent = (MainWindow)Application.Current.MainWindow;

        string pref = "";
        string code = "";
        string area = "";
      //  WebClient wc;
        public string hotelname;


        public HotelShow(string pref,string code,string area)
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
                "https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=json&largeClassCode=japan&middleClassCode={0}&smallClassCode={1}&applicationId=1023910507139864215",pref,code);
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
            

            lbPrefName.Content = area+"　ホテル・旅館";
            lbRecordCount.Content = String.Format("{0}件中", recordcount);
            lbDisplay.Content = String.Format("{0}～{1}表示", displayfirst, displaylast);
            lbHotelName.Content = hotelname;
            lbServiceAverage.Content = serviceaverage;
            lbHotelSpecial.Content = hotelspecial;
            lbPostalCode.Content = String.Format("〒{0}",postalcode);
            lbaddress.Content = String.Format("{0}{1}", address1, address2);
            lbaccess.Content = access;
            lbMinCharge.Content = String.Format("{0:N0}円～", mincharge);


            if (serviceaverage >= 5){
                ;
            }else if(serviceaverage >= 3.8){
                im5.Source = null;
            }else if(serviceaverage >= 2.8){
                im5.Source = null;
                im4.Source = null;
            }else if(serviceaverage >= 1.8){
                im5.Source = null;
                im4.Source = null;
                im3.Source = null;
            }else if(serviceaverage >= 1){
                im5.Source = null;
                im4.Source = null;
                im3.Source = null;
                im2.Source = null;
            }else{
                im5.Source = null;
                im4.Source = null;
                im3.Source = null;
                im2.Source = null;
                im1.Source = null;
            }
        }

        private void btMap_Click(object sender, RoutedEventArgs e)
        {
            Map map = new Map(pref,code);
            map.Show();
        }

        private void btRecommend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btAreaSelect_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
