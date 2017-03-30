using DM.MovieApi.ApiResponse;
using DM.MovieApi.MovieDb.Movies;
using DM.MovieApi.MovieDb.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Movie_Manager
{
    class Search : TMDB
    {
        private ApiSearchResponse<Movie> Movies;
        private ApiSearchResponse<MovieInfo> MovieInfos;

        public enum filters
        {
            Actor,
            Name,
            Genre
        }

        public Search()
            :base()
        {

        }

        private List<PersonInfoRole> SearchByActor(string _actorName)
        {
            return GetMoviesByActor(_actorName).Result;
        }

        private List<MovieInfo> SearchByName(string _movieName)
        {
            MovieInfos = GetMovieByName(_movieName, 1).Result;
            return new List<MovieInfo>(MovieInfos.Results);
        }

        private List<MovieInfo> SearchByGenre(string _genre)
        {
            int genreID;
            Genres.TryGetValue(_genre, out genreID);
            MovieInfos = GetMovieByGenre(genreID, 1).Result;

            return new List<MovieInfo>(MovieInfos.Results);
        }

        //private List<Movie> SearchByYear(string _date) { }

        //Private List<Movie> SearchByLanguage() { }
    }
}
