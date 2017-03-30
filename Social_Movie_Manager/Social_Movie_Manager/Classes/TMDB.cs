using System.Collections.Generic;
using DM.MovieApi.ApiResponse;
using DM.MovieApi.MovieDb.Movies;
using DM.MovieApi.MovieDb.Genres;

namespace Social_Movie_Manager
{
    public class TMDB : Api
    {
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
            :base()
        {
            
            Genres = new Dictionary<string, int>();
            foreach (var item in GenreFactory.GetAll())
            {
                Genres.Add(item.Name, item.Id);
            }
        }

        public void _GetMovieByID(ref Movie _movie, int _id)
        {
            _movie = GetMovieByID(_id).Result;
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
