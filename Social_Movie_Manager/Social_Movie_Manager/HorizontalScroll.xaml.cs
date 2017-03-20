using DM.MovieApi.MovieDb.Movies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Social_Movie_Manager
{
    public sealed partial class HorizontalScroll : UserControl
    {
        public void CreateElementsMovieInfo(ref List<MovieInfo> _movieInfo)
        {
            int index = 0;
            //_root.Children.Clear();
            _root.ColumnDefinitions.Clear();
            _root.Height = 160;
            _root.RowDefinitions.Add(new RowDefinition());

            foreach (var item in _movieInfo)
            {
                _root.ColumnDefinitions.Add(new ColumnDefinition());
                Button btn = new Button();
                Image img = new Image();
                TextBlock txt = new TextBlock();
                Thickness txtMargin = new Thickness(5, 0, 10, 5);

                img.Source = new BitmapImage(new Uri(string.Format("http://image.tmdb.org/t/p/w342{0}", item.PosterPath)));
                btn.Content = img;
                txt.Text = item.Title;

                //Button settings
                btn.Height = 130;
                btn.Width = 130;
                btn.Background = new SolidColorBrush(Colors.Black);
                btn.VerticalAlignment = VerticalAlignment.Top;
                btn.SetValue(Grid.ColumnProperty, index);

                //Textbox settings
                txt.TextWrapping = TextWrapping.WrapWholeWords;
                txt.TextAlignment = TextAlignment.Center;
                txt.Foreground = new SolidColorBrush(Colors.Black);
                txt.FontSize = 14;
                txt.VerticalAlignment = VerticalAlignment.Bottom;
                txt.Margin = txtMargin;
                txt.Height = 35;
                txt.SetValue(Grid.ColumnProperty, index);
                index = index + 1;

                _root.Children.Add(btn);
                _root.Children.Add(txt);
            }
            this.UpdateLayout();
        }

        public HorizontalScroll()
        {
            this.InitializeComponent();
        }
    }
}