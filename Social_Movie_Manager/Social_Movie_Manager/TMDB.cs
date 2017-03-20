using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DM.MovieApi.ApiResponse;
using DM.MovieApi;
using DM.MovieApi.MovieDb.Movies;
using DM.MovieApi.MovieDb.Genres;
using DM.MovieApi.ApiRequest;
using System.Collections.ObjectModel;

namespace Social_Movie_Manager
{
    public class TMDB
    {
        IApiMovieRequest MovieApi;
        IApiGenreRequest GenreApi;
        public Dictionary<string, int> Genres;
        public enum SearchType
        {
            ByName, 
            Popular,
            Upcoming,
            NowPlaying,
            TopRated,
            Genre
        };

        //Custom constructor
        public TMDB()
        {
            MovieDbFactory.RegisterSettings("49654d7090b510dbd0733c03917c7caf", "http://api.themoviedb.org/3/");
            MovieApi = MovieDbFactory.Create<IApiMovieRequest>().Value;
            GenreApi = MovieDbFactory.Create<IApiGenreRequest>().Value;
            Genres = new Dictionary<string, int>();
            foreach (var item in GenreApi.AllGenres)
            {
                Genres.Add(item.Name, item.Id);
            }
        }

        //Get all the movies that are popular at the moment

        public async Task<ApiSearchResponse<MovieInfo>> GetPopularMovies(int _page)
        {
            ApiSearchResponse<MovieInfo> response = await MovieApi.GetPopularAsync(_page, "en");
            return response;
        }

        //Get all the movies that are now in the cinemas

        public async Task<ApiSearchResponse<Movie>> GetNowPlayingMovies(int _page)
        {
            ApiSearchResponse<Movie> response = await MovieApi.GetNowPlayingAsync(_page, "en");
            return response;
        }

        //Find a movie by it's name
        public async Task<ApiSearchResponse<MovieInfo>> GetMovieByName(string _name, int _page)
        {
            ApiSearchResponse<MovieInfo> response = await MovieApi.SearchByTitleAsync(_name, _page, "en");
            return response;
        }

        //Get all the upcoming movies
        public async Task<ApiSearchResponse<Movie>> GetUpcomingMovies(int _page)
        {
            ApiSearchResponse<Movie> response = await MovieApi.GetUpcomingAsync(_page, "en");
            
            return response;
        }

        //Get all toprated movies
        public async Task<ApiSearchResponse<MovieInfo>> GetTopRatedMovies(int _page)
        {
            ApiSearchResponse<MovieInfo> response = await MovieApi.GetTopRatedAsync(_page, "en");
           
            return response;
        }

        //Get movie cast by movieID (to be used with one of the other methods
        public async Task<ApiQueryResponse<MovieCredit>> GetCastByMovie(int _movieID)
        {
            ApiQueryResponse<MovieCredit> response = await MovieApi.GetCreditsAsync(_movieID, "en");
            return response;
        }



        public async Task<ApiSearchResponse<MovieInfo>> GetMovieByGenre(int _genreID, int _page)
        {
            ApiSearchResponse<MovieInfo> response = await GenreApi.FindMoviesByIdAsync(_genreID, _page, "en");

            return response;
        }

   

        //Get movies together with it's cast
        //Put in dictionary<object, moviecredit> by parallel foreach
        public ObservableCollection<object> GetFullMovieInfo(SearchType _searchType,int _page, string _movieName = null, int _genreID = 0)
        {
            ObservableCollection<object> list = new ObservableCollection<object>();
            ApiSearchResponse<MovieInfo> movieInfos;
            ApiSearchResponse<Movie> movies;

            switch (_searchType)
            {
                case SearchType.ByName:
                    movieInfos = GetMovieByName(_movieName, _page).Result;
                    list.Add(movieInfos.Results);
                    
                    break;
                case SearchType.Popular:
                    movieInfos = GetPopularMovies(_page).Result;
                    list.Add(movieInfos.Results);
                        break;
                case SearchType.Upcoming:
                    movies = GetUpcomingMovies(_page).Result;
                    list.Add(movies.Results);
                    break;
                case SearchType.NowPlaying:
                    movies = GetNowPlayingMovies(_page).Result;
                    list.Add(movies.Results);
                    break;
                case SearchType.TopRated:
                    movieInfos = GetTopRatedMovies(_page).Result;
                    list.Add(movieInfos.Results);
                    break;
                case SearchType.Genre:
                    movieInfos = GetMovieByGenre(_genreID,_page).Result;
                    list.Add(movieInfos.Results);
                    break;
            }
            return list;
        }




    }
}
