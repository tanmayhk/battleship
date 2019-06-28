﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SubSweeper
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StartPage : Page
    {
        public StartPage()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            string urisource1 = $"/Assets/4x4.png";
            Image img1 = new Image()
            {
                Source = new BitmapImage(new Uri(this.BaseUri, urisource1)),
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            Size4.Padding = new Thickness(0, 0, 0, 0);
            Size4.BorderThickness = new Thickness(0, 0, 0, 0);
            Size4.Content = img1;

            string urisource2 = $"/Assets/5x5.png"; 
            Image img2 = new Image()
            {
                Source = new BitmapImage(new Uri(this.BaseUri, urisource2)),
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            Size5.Padding = new Thickness(0, 0, 0, 0);
            Size5.BorderThickness = new Thickness(0, 0, 0, 0);
            Size5.Content = img2;

            string urisource3 = $"/Assets/6x6.png";
            Image img3 = new Image()
            {
                Source = new BitmapImage(new Uri(this.BaseUri, urisource3)),
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            Size6.Padding = new Thickness(0, 0, 0, 0);
            Size6.BorderThickness = new Thickness(0, 0, 0, 0);
            Size6.Content = img3;

            string urisource4 = $"/Assets/7x7.png";
            Image img4 = new Image()
            {
                Source = new BitmapImage(new Uri(this.BaseUri, urisource4)),
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            Size7.Padding = new Thickness(0, 0, 0, 0);
            Size7.BorderThickness = new Thickness(0, 0, 0, 0);
            Size7.Content = img4;
        }

        private void Size4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), 4);
        }

        private void Size5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), 5);
        }

        private void Size6_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), 6);
        }

        private void Size7_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), 7);
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void HowToPlayButton_Click(object sender, RoutedEventArgs e)
        {
            HowtoPlayGrid.Visibility = Visibility.Visible;
        }

        private void ClosePlay_Click(object sender, RoutedEventArgs e)
        {
            HowtoPlayGrid.Visibility = Visibility.Collapsed;
        }
    }
}
