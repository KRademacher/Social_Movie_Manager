using DM.MovieApi.MovieDb.Movies;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Phone.UI.Input;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Social_Movie_Manager.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ExplorePage : Page
    {
        private TMDB tmdb;
        private List<MovieInfo> PopularMovies = new List<MovieInfo>();
        private List<Movie> UpcomingMovies = new List<Movie>();
        private List<Movie> NITMovies = new List<Movie>();
        private int PopPage = 1;
        private int UpComPage = 1;
        private int NITPage = 1;
        public ExplorePage()
        {
            this.InitializeComponent();
            DrawerLayout.InitializeDrawerLayout();

            //Initialize the movie db api
            tmdb = new TMDB();

            //Add on_click handlers
            Popular.Tapped += Popular_Tapped;
            Upcoming.Tapped += Upcoming_Tapped;
            NowInTheaters.Tapped += NowInTheaters_Tapped;

            //Add movies to list in background
            Task.Run(() =>
            {
                PopularMovies.AddRange(tmdb.GetMovieInfo(TMDB.SearchType.Popular, PopPage));
                UpcomingMovies.AddRange(tmdb.GetMovie(TMDB.SearchType.Upcoming, UpComPage));
                NITMovies.AddRange(tmdb.GetMovie(TMDB.SearchType.NowPlaying, NITPage));
                UpdateUIAsync();
            });

        }

        //Update the GUI async
        private async void UpdateUIAsync()
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
            {
                Popular.CreateElementsMovieInfo(ref PopularMovies, true, "Popular");
                Upcoming.CreateElementsMovie(ref UpcomingMovies, true, "Upcoming");
                NowInTheaters.CreateElementsMovie(ref NITMovies, true, "Now in the theaters");
            });
        }

        private async void UpdateUIPop()
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
            {
                Popular.CreateElementsMovieInfo(ref PopularMovies, true, "Popular");
            });
        }

        private async void UpdateUIUpCom()
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
            {
                Upcoming.CreateElementsMovie(ref UpcomingMovies, true, "Upcoming");
            });
        }

        private async void UpdateUINIT()
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
            {
                NowInTheaters.CreateElementsMovie(ref NITMovies, true, "Now in the theaters");
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

        private void NowInTheaters_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Image root = null;
            TextBlock _root = null;

            root = e.OriginalSource as Image;
            if (root == null)
            {
                _root = e.OriginalSource as TextBlock;
                if (_root.Text.ToUpper() == "LOAD MORE")
                {
                    NITPage++;
                    Task.Run(() =>
                    {
                        NITMovies.AddRange(tmdb.GetMovie(TMDB.SearchType.NowPlaying, NITPage));
                        UpdateUINIT();
                    });
                }
                else
                {
                    int movieId = Convert.ToInt32(root.Name);
                }

            }
            else
            {
                if (root.Name.ToUpper() == "LOAD_MORE")
                {
                    NITPage++;
                    Task.Run(() =>
                    {
                        NITMovies.AddRange(tmdb.GetMovie(TMDB.SearchType.NowPlaying, NITPage));
                        UpdateUINIT();
                    });
                }
                else
                {
                    int movieId = Convert.ToInt32(root.Name);
                }
            }
        }

        private void Upcoming_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Image root = null;
            TextBlock _root = null;

            root = e.OriginalSource as Image;
            if (root == null)
            {
                _root = e.OriginalSource as TextBlock;
                if (_root.Text.ToUpper() == "LOAD MORE")
                {
                    UpComPage++;
                    Task.Run(() =>
                    {
                        UpcomingMovies.AddRange(tmdb.GetMovie(TMDB.SearchType.Upcoming, UpComPage));
                        UpdateUIUpCom();
                    });
                }
                else
                {
                    int movieId = Convert.ToInt32(root.Name);
                }

            }
            else
            {
                if (root.Name.ToUpper() == "LOAD_MORE")
                {
                    PopPage++;
                    Task.Run(() =>
                    {
                        PopularMovies.AddRange(tmdb.GetMovieInfo(TMDB.SearchType.Popular, PopPage));
                        UpdateUIPop();
                    });
                }
                else
                {
                    int movieId = Convert.ToInt32(root.Name);
                }
            }
        }

        private void Popular_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Image root = null;
            TextBlock _root = null;

            root = e.OriginalSource as Image;
            if (root == null)
            {
                _root = e.OriginalSource as TextBlock;
                if (_root.Text.ToUpper() == "LOAD MORE")
                {
                    PopPage++;
                    Task.Run(() =>
                    {
                        PopularMovies.AddRange(tmdb.GetMovieInfo(TMDB.SearchType.Popular, PopPage));
                        UpdateUIPop();
                    });
                }
                else
                {
                    int movieId = Convert.ToInt32(root.Name);
                }

            }
            else
            {
                if (root.Name.ToUpper() == "LOAD_MORE")
                {
                    PopPage++;
                    Task.Run(() =>
                    {
                        PopularMovies.AddRange(tmdb.GetMovieInfo(TMDB.SearchType.Popular, PopPage));
                        UpdateUIPop();
                    });
                }
                else
                {
                    int movieId = Convert.ToInt32(root.Name);
                }
            }
        }
    }
}