using DM.MovieApi.MovieDb.Movies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Social_Movie_Manager.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public class MovieInfoPageData
    {
        public int MovieID { get; set; }
        public string Overview { get; set; }

        public BitmapImage img { get; set; }

        public double rating { get; set; }
    }


    public sealed partial class MovieInfoPage : Page
    {
        private int MovieID;
        private TMDB tmdb;
        private Movie Movie = new Movie();
        private SolidColorBrush brush = new SolidColorBrush(Colors.Black);
        public MovieInfoPage()
        {
            tmdb = new TMDB();

            this.InitializeComponent();
            this.MainFragment.Background = new SolidColorBrush(RandomColorGen.GetRandomColor());

            Task.Run(() =>
            {
                do
                {
                    tmdb._GetMovieByID(ref Movie, MovieID);
                } while (Movie == null);
               
                UpdateUIAsync();
            });
        }


        private async void UpdateUIAsync()
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
            {
                //Title
                Movie_Title.Foreground = new SolidColorBrush(Colors.White);
                Movie_Title.Margin = new Thickness(0, 15, 0, 0);
                Movie_Title.Text = Movie.Title;

                //SubTitle
                Movie_Subtitle.Foreground = new SolidColorBrush(Colors.White);
                Movie_Title.Margin = new Thickness(0, 0, 0, 5);
                Movie_Subtitle.Text = Movie.Tagline;

                //Movie Poster
                Movie_Poster.Margin = new Thickness(0, 5, 0, 5);
                Movie_Poster.Source = new BitmapImage(new Uri(string.Format("http://image.tmdb.org/t/p/w500{0}", Movie.PosterPath)));

                //Movie Rating
                Movie_Rating.FontFamily = new FontFamily("Segoe UI");
                Movie_Rating.FontSize = 12;
                Movie_Rating.Foreground = new SolidColorBrush(Colors.White);
                Movie_Rating.Text = "Rating: " + Movie.VoteAverage.ToString() + " out of " + Movie.VoteCount.ToString() + " votes.";


                //Movie overview
                Movie_Info.Foreground = new SolidColorBrush(Colors.White);
                Movie_Info.Margin = new Thickness(0, 20, 0, 0);
                Movie_Info.FontSize = 16;
                Movie_Info.FontFamily = new FontFamily("Segoe UI");
                Movie_Info.Text = Movie.Overview;
            });
        }

       

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
            MovieID = (int)e.Parameter;
        }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            //if (Frame.CanGoBack)
            //{
            //    Frame.GoBack();
            //    e.Handled = true;
            //}
            //else
            //    Application.Current.Exit();
        }

        private void Movie_Reviews_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void Facebook_Button_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void Twitter_Button_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}