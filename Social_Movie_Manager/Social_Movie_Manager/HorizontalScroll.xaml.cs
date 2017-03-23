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
        public void CreateElementsMovieInfo(ref List<MovieInfo> _movieInfo, bool _setTitle, string _title = null)
        {
           
            _root.Children.Clear();
            int index = 0;
            _root.Height = 160;
            _root.RowDefinitions.Add(new RowDefinition());

            // !!OPTIONAL!! Set title text and title settings
            if (_setTitle)
            {
                Title.Text = _title;
            }

            //Create button and textblock for every movie
            foreach (var item in _movieInfo)
            {
                //Initialize button, image, textblock and margin
                Button btn = new Button();
                Image img = new Image();
                TextBlock txt = new TextBlock();
                Thickness txtMargin = new Thickness(5, 0, 10, 5);

                //Set element info
                _root.ColumnDefinitions.Add(new ColumnDefinition());
                img.Source = new BitmapImage(new Uri(string.Format("http://image.tmdb.org/t/p/w342{0}", item.PosterPath)));
                img.Name = item.Id.ToString();
                btn.Content = img;
                txt.Text = item.Title;

                //Button settings
                btn.Height = 130;
                btn.Width = 130;
                btn.Background = new SolidColorBrush(Colors.White);
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
                txt.Width = 110;    
                txt.SetValue(Grid.ColumnProperty, index);

                index = index + 1;

                //Add elements to grid
                try
                {
                    _root.Children.Add(btn);
                    _root.Children.Add(txt);
                }
                catch (ArgumentException ex)
                {

                    
                }
               
                if (item == _movieInfo.Last())
                {
                    //Button settings
                    Image img2 = new Image();
                    img2.Source = new BitmapImage(new Uri("ms-appx:///Assets/load_more.png", UriKind.RelativeOrAbsolute));
                    img2.Name = "Load_More";
                    btn.Content = img2;

                    btn.Height = 130;
                    btn.Width = 130;
                    btn.Background = new SolidColorBrush(Colors.White);
                    btn.VerticalAlignment = VerticalAlignment.Top;
                    btn.SetValue(Grid.ColumnProperty, index);

                    //Textbox settings
                    txt.Text = "Load More";

                    txt.TextWrapping = TextWrapping.WrapWholeWords;
                    txt.TextAlignment = TextAlignment.Center;
                    txt.Foreground = new SolidColorBrush(Colors.Black);
                    txt.FontSize = 14;
                    txt.VerticalAlignment = VerticalAlignment.Bottom;
                    txt.Margin = txtMargin;
                    txt.Height = 35;
                    txt.Width = 110;
                    txt.SetValue(Grid.ColumnProperty, index);
                }
            }
            this.UpdateLayout();
        }

        public void CreateElementsMovie(ref List<Movie> _movieInfo, bool _setTitle, string _title = null)
        {
            int index = 0;
            _root.Height = 160;
            _root.RowDefinitions.Add(new RowDefinition());

            // !!OPTIONAL!! Set title text and title settings
            if (_setTitle)
            {
                Title.Text = _title;
            }

            foreach (var item in _movieInfo)
            {
                //Initialize button, image, textblock and margin
                Button btn = new Button();
                Image img = new Image();
                TextBlock txt = new TextBlock();
                Thickness txtMargin = new Thickness(5, 0, 10, 5);

                //Set element info
                _root.ColumnDefinitions.Add(new ColumnDefinition());
                img.Source = new BitmapImage(new Uri(string.Format("http://image.tmdb.org/t/p/w342{0}", item.PosterPath)));
                img.Name = item.Id.ToString();
                btn.Content = img;
                txt.Text = item.Title;

                //Button settings
                btn.Height = 130;
                btn.Width = 130;
                btn.Background = new SolidColorBrush(Colors.White);
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
                txt.Width = 110;
                txt.SetValue(Grid.ColumnProperty, index);
               
                index = index + 1;

                try
                {
                    _root.Children.Add(btn);
                    _root.Children.Add(txt);

                }
                catch (ArgumentException ex)
                {
                    index = index - 1;
                }
               
                if (item == _movieInfo.Last())
                {
                    //Button settings
                    Image img2 = new Image();
                    img2.Source = new BitmapImage(new Uri("ms-appx:///Assets/load_more.png", UriKind.RelativeOrAbsolute));
                    img2.Name = "Load_More";
                    btn.Content = img2;

                    btn.Height = 130;
                    btn.Width = 130;
                    btn.Background = new SolidColorBrush(Colors.White);
                    btn.VerticalAlignment = VerticalAlignment.Top;
                    btn.SetValue(Grid.ColumnProperty, index);
                    
                    //Textbox settings
                    txt.Text = "Load More";

                    txt.TextWrapping = TextWrapping.WrapWholeWords;
                    txt.TextAlignment = TextAlignment.Center;
                    txt.Foreground = new SolidColorBrush(Colors.Black);
                    txt.FontSize = 14;
                    txt.VerticalAlignment = VerticalAlignment.Bottom;
                    txt.Margin = txtMargin;
                    txt.Height = 35;
                    txt.Width = 110;
                    txt.SetValue(Grid.ColumnProperty, index);
                }
            }
            this.UpdateLayout();
        }

        public void LoadMoreMovieInfos(ref List<MovieInfo> _movieInfo)
        {
            
            CreateElementsMovieInfo(ref _movieInfo, false);
        }
        public HorizontalScroll()
        {
            this.InitializeComponent();
        }
    }
}