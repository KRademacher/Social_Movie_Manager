using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Social_Movie_Manager
{
    public sealed partial class HorizontalScroll : UserControl
    {
        public object Button1Content
        {
            get { return this.Button1.Content; }
            set { this.Button1.Content = value; }
        }
        public object Button2Content
        {
            get { return this.Button2.Content; }
            set { this.Button2.Content = value; }
        }
        public object Button3Content
        {
            get { return this.Button3.Content; }
            set { this.Button3.Content = value; }
        }
        public object Button4Content
        {
            get { return this.Button4.Content; }
            set { this.Button4.Content = value; }
        }
        public string TextBlock1Content
        {
            get { return this.TextBlock1.Text; }
            set { this.TextBlock1.Text = value; }
        }
        public string TextBlock2Content
        {
            get { return this.TextBlock2.Text; }
            set { this.TextBlock2.Text = value; }
        }
        public string TextBlock3Content
        {
            get { return this.TextBlock3.Text; }
            set { this.TextBlock3.Text = value; }
        }
        public string TextBlock4Content
        {
            get { return this.TextBlock4.Text; }
            set { this.TextBlock4.Text = value; }
        }

        public HorizontalScroll()
        {
            this.InitializeComponent();

            Image image = new Image();
            image.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(@"ms-appx:/Assets/drawer_icon.png", UriKind.RelativeOrAbsolute));
            Button1Img = image;
        }
    }
}