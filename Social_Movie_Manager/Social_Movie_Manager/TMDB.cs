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

        private async Task<ApiSearchResponse<MovieInfo>> GetPopularMovies(int _page)
        {
            ApiSearchResponse<MovieInfo> response = await MovieApi.GetPopularAsync(_page, "en");
            return response;
        }

        //Get all the movies that are now in the cinemas

        private async Task<ApiSearchResponse<Movie>> GetNowPlayingMovies(int _page)
        {
            ApiSearchResponse<Movie> response = await MovieApi.GetNowPlayingAsync(_page, "en");
            return response;
        }

        //Find a movie by it's name
        private async Task<ApiSearchResponse<MovieInfo>> GetMovieByName(string _name, int _page)
        {
            ApiSearchResponse<MovieInfo> response = await MovieApi.SearchByTitleAsync(_name, _page, "en");
            return response;
        }

        //Get all the upcoming movies
        private async Task<ApiSearchResponse<Movie>> GetUpcomingMovies(int _page)
        {
            ApiSearchResponse<Movie> response = await MovieApi.GetUpcomingAsync(_page, "en");
            
            return response;
        }

        //Get all toprated movies
        private async Task<ApiSearchResponse<MovieInfo>> GetTopRatedMovies(int _page)
        {
            ApiSearchResponse<MovieInfo> response = await MovieApi.GetTopRatedAsync(_page, "en");
           
            return response;
        }

        //Get movie cast by movieID (to be used with one of the other methods
        private async Task<ApiQueryResponse<MovieCredit>> GetCastByMovie(int _movieID)
        {
            ApiQueryResponse<MovieCredit> response = await MovieApi.GetCreditsAsync(_movieID, "en");
            return response;
        }



        private async Task<ApiSearchResponse<MovieInfo>> GetMovieByGenre(int _genreID, int _page)
        {
            ApiSearchResponse<MovieInfo> response = await GenreApi.FindMoviesByIdAsync(_genreID, _page, "en");

            return response;
        }

        public List<Movie> GetMovie(SearchType _searchType, int _page)
        {
            ApiSearchResponse<Movie> Movies;

            switch (_searchType)
            {
                case SearchType.Upcoming:
                    Movies = GetUpcomingMovies(_page).Result;
                    return new List<Movie>(Movies.Results);
                case SearchType.NowPlaying:
                    Movies = GetNowPlayingMovies(_page).Result;
                    return new List<Movie>(Movies.Results);
                default:
                    return null;
            }   
        }

        //Get movies together with it's cast
        //Put in dictionary<object, moviecredit> by parallel foreach
        public List<MovieInfo> GetMovieInfo( SearchType _searchType,int _page, string _movieName = null, int _genreID = 0)
        {
            ApiSearchResponse<MovieInfo> movieInfos;

            switch (_searchType)
            {
                case SearchType.ByName:
                    movieInfos = GetMovieByName(_movieName, _page).Result;
                    return new List<MovieInfo>(movieInfos.Results);
                case SearchType.Popular:
                    movieInfos = GetPopularMovies(_page).Result;
                    return new List<MovieInfo>(movieInfos.Results);
                case SearchType.TopRated:
                    movieInfos = GetTopRatedMovies(_page).Result;
                    return new List<MovieInfo>(movieInfos.Results);
                case SearchType.Genre:
                    movieInfos = GetMovieByGenre(_genreID,_page).Result;
                    return new List<MovieInfo>(movieInfos.Results);
                default:
                    return null;
            }
        }
    }
}
