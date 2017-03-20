using DM.MovieApi.MovieDb.Movies;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.Phone.UI.Input;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Social_Movie_Manager.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ExplorePage : Page
    {
        TMDB tmdb;
        public List<MovieInfo> Popular;
        public ExplorePage()
        {
            this.InitializeComponent();
            DrawerLayout.InitializeDrawerLayout();

            tmdb = new TMDB();

            HorizontalScroll1.DataContext = Popular;
            Task.Run(() =>
            {
                Popular = tmdb.GetMovieInfo(TMDB.SearchType.Popular, 1);
                UpdateUI();
            });

        }

        private async void UpdateUI()
        {

            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                HorizontalScroll1.TextBlock1Content = Popular[0].Title;

                Image image = new Image();
                image.Source = new BitmapImage(new Uri(string.Format("http://image.tmdb.org/t/p/w342{0}", Popular[0].PosterPath)));
                HorizontalScroll1.Button1Content = image;

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
        }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            if (DrawerLayout.IsDrawerOpen)
            {
                DrawerLayout.CloseDrawer();
                e.Handled = true;
            }
            else
                Application.Current.Exit();
        }

        private void DrawerIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (DrawerLayout.IsDrawerOpen)
                DrawerLayout.CloseDrawer();
            else
                DrawerLayout.OpenDrawer();
        }

        private void SlideMenu_LostFocus(object sender, RoutedEventArgs e)
        {
            DrawerLayout.CloseDrawer();
        }
    }
}