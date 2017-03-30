using DM.MovieApi.MovieDb.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Social_Movie_Manager
{
    public sealed partial class HorizontalScroll : UserControl
    {
        public HorizontalScroll()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Creates all the elements shown in the GUI
        /// </summary>
        /// <param name="_movieInfo"></param>
        /// <param name="_setTitle"></param>
        /// <param name="_title"></param>
        public void CreateElementsMovieInfo(ref List<MovieInfo> _movieInfo, SolidColorBrush _brush, bool _setTitle, string _title = null)
        {
            int index = 0;
            _root.Background = _brush;
          

            //Remove duplicates
            RemoveDups(ref _movieInfo);

            //Clear the grid
            _root.Children.Clear();
            _root.ColumnDefinitions.Clear();
            _root.RowDefinitions.Clear();

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
                btn.Background = _brush;
                btn.Foreground = _brush;
                btn.BorderBrush = _brush;

                btn.VerticalAlignment = VerticalAlignment.Top;
                btn.SetValue(Grid.ColumnProperty, index);

                //Textbox settings
                txt.TextWrapping = TextWrapping.WrapWholeWords;
                txt.TextAlignment = TextAlignment.Center;
                txt.Foreground = new SolidColorBrush(Colors.White);
                txt.FontSize = 14;
                txt.VerticalAlignment = VerticalAlignment.Bottom;
                txt.Margin = txtMargin;
                txt.Height = 35;
                txt.Width = 110;    
                txt.SetValue(Grid.ColumnProperty, index);

                //Add elements to grid
                
                _root.Children.Add(btn);
                _root.Children.Add(txt);

                index = index + 1;
                
                if (item == _movieInfo.Last())
                {
                    //Button settings
                    Image img2 = new Image();
                    img2.Source = new BitmapImage(new Uri("ms-appx:///Assets/load_more.png", UriKind.RelativeOrAbsolute));
                    img2.Name = "Load_More";
                    btn.Content = img2;

                    btn.Height = 130;
                    btn.Width = 130;
                    btn.Background = _brush;
                    btn.Foreground = _brush;
                    btn.BorderBrush = _brush;

                    btn.VerticalAlignment = VerticalAlignment.Top;
                    btn.SetValue(Grid.ColumnProperty, index);

                    //Textbox settings
                    txt.Text = "Load More";

                    txt.TextWrapping = TextWrapping.WrapWholeWords;
                    txt.TextAlignment = TextAlignment.Center;
                    txt.Foreground = new SolidColorBrush(Colors.White);
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

        public void CreateElementsMovie(ref List<Movie> _movieInfo, SolidColorBrush _brush, bool _setTitle, string _title = null)
        {
            _root.Background = _brush;
          
            RemoveDups(ref _movieInfo);
            _root.Children.Clear();
            _root.ColumnDefinitions.Clear();
            _root.RowDefinitions.Clear();

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
                btn.Background = _brush;
                btn.Foreground = _brush;
                btn.BorderBrush = _brush;
                btn.VerticalAlignment = VerticalAlignment.Top;
                btn.SetValue(Grid.ColumnProperty, index);

                //Textbox settings
                txt.TextWrapping = TextWrapping.WrapWholeWords;
                txt.TextAlignment = TextAlignment.Center;
                txt.Foreground = new SolidColorBrush(Colors.White);
                txt.FontSize = 14;
                txt.VerticalAlignment = VerticalAlignment.Bottom;
                txt.Margin = txtMargin;
                txt.Height = 35;
                txt.Width = 110;
                txt.SetValue(Grid.ColumnProperty, index);
               
                _root.Children.Add(btn);
                _root.Children.Add(txt);

                index = index + 1;

                if (item == _movieInfo.Last())
                {
                    //Button settings
                    Image img2 = new Image();
                    img2.Source = new BitmapImage(new Uri("ms-appx:///Assets/load_more.png", UriKind.RelativeOrAbsolute));
                    img2.Name = "Load_More";
                    btn.Content = img2;

                    btn.Height = 130;
                    btn.Width = 130;
                    btn.Background = _brush;
                    btn.Foreground = _brush;
                    btn.BorderBrush = _brush;

                    btn.VerticalAlignment = VerticalAlignment.Top;
                    btn.SetValue(Grid.ColumnProperty, index);
                    
                    //Textbox settings
                    txt.Text = "Load More";

                    txt.TextWrapping = TextWrapping.WrapWholeWords;
                    txt.TextAlignment = TextAlignment.Center;
                    txt.Foreground = new SolidColorBrush(Colors.White);
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


        /// <summary>
        /// Remove duplicates in the movieLists by using linq. 
        /// </summary>
        /// <param name="_movieList"></param>
        private void RemoveDups(ref List<Movie> _movieList)
        {
            _movieList = _movieList.GroupBy(x => x.Id).Select(x => x.First()).ToList();
        }

        private void RemoveDups(ref List<MovieInfo> _movieList)
        {
            _movieList = _movieList.GroupBy(x => x.Id).Select(x => x.First()).ToList();
        }

    }
}