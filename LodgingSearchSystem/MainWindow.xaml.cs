﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace LodgingSearchSystem {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public IDictionary<string, string> Areanames;

        private NavigationService _navi;    //ナビゲーションサービス
        public MainWindow() {
            InitializeComponent();
            _navi = this.frame.NavigationService;

            Areanames = ReadAreas("areaname.csv");
        }
        public static IDictionary<string, string> ReadAreas(string filePath)
        {
            var dict = new Dictionary<string, string>();
            //List<Area> areas = new List<Area>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                dict.Add(items[0], items[1]);
            }
            return dict;
        }

        private void frame_Loaded(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Japan.xaml", UriKind.Relative);
            frame.Source = uri;
        }

        private void btmenu_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Japan.xaml", UriKind.Relative);
            frame.Source = uri;
        }
    }
}
