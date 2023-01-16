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
    /// hotelShow.xaml の相互作用ロジック
    /// </summary>
    public partial class HotelShow : Page
    {
        WebClient wc;
        public string hotelname;


        public HotelShow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            string regionnum = string.Format("https://app.rakuten.co.jp/services/api/Travel/GetAreaClass/20131024?format=json&applicationId=1023910507139864215");
            var dString1 = wc.DownloadString(regionnum);
            var json1 = JsonConvert.DeserializeObject<Rootobject>(dString1);
        }
    }
}
