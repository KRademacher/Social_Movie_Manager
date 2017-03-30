using DM.MovieApi;
using DM.MovieApi.ApiResponse;
using DM.MovieApi.MovieDb.Genres;
using DM.MovieApi.MovieDb.Movies;
using DM.MovieApi.MovieDb.People;
using DM.MovieApi.ApiRequest;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using Windows.Data.Json;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;

namespace Social_Movie_Manager
{
    public class Api
    {
        protected IApiMovieRequest MovieApi;
        protected IApiGenreRequest GenreApi;
        protected IApiRequest request;
        protected Newtonsoft.Json.JsonConverter JsonCoverter;

        protected Api()
        {
            MovieDbFactory.RegisterSettings("49654d7090b510dbd0733c03917c7caf", "http://api.themoviedb.org/3/");
            MovieApi = MovieDbFactory.Create<IApiMovieRequest>().Value;
            GenreApi = MovieDbFactory.Create<IApiGenreRequest>().Value;
        }


        //Get all the movies that are popular at the moment

        protected async Task<ApiSearchResponse<MovieInfo>> GetPopularMovies(int _page)
        {
            ApiSearchResponse<MovieInfo> response = await MovieApi.GetPopularAsync(_page, "en");
            return response;
        }

        //Get all the movies that are now in the cinemas

        protected async Task<ApiSearchResponse<Movie>> GetNowPlayingMovies(int _page)
        {
            ApiSearchResponse<Movie> response = await MovieApi.GetNowPlayingAsync(_page, "en");
            return response;
        }

        //Find a movie by it's name
        protected async Task<ApiSearchResponse<MovieInfo>> GetMovieByName(string _name, int _page)
        {
            ApiSearchResponse<MovieInfo> response = await MovieApi.SearchByTitleAsync(_name, _page, "en");
            return response;
        }

        //Get all the upcoming movies
        protected async Task<ApiSearchResponse<Movie>> GetUpcomingMovies(int _page)
        {
            ApiSearchResponse<Movie> response = await MovieApi.GetUpcomingAsync(_page, "en");

            return response;
        }

        //Get all toprated movies
        protected async Task<ApiSearchResponse<MovieInfo>> GetTopRatedMovies(int _page)
        {
            ApiSearchResponse<MovieInfo> response = await MovieApi.GetTopRatedAsync(_page, "en");

            return response;
        }

        //Get movie cast by movieID (to be used with one of the other methods
        protected async Task<ApiQueryResponse<MovieCredit>> GetCastByMovie(int _movieID)
        {
            ApiQueryResponse<MovieCredit> response = await MovieApi.GetCreditsAsync(_movieID, "en");
            return response;
        }


        protected async Task<ApiSearchResponse<MovieInfo>> GetMovieByGenre(int _genreID, int _page)
        {
            ApiSearchResponse<MovieInfo> response = await GenreApi.FindMoviesByIdAsync(_genreID, _page, "en");

            return response;
        }

        //Get ActorID by name
        protected async Task<int> GetActor(string _actor)
        {
            PersonInfo info = new PersonInfo();
            var hc = new HttpClient();
            
            var resp = await hc.GetAsync(new Uri("http://api.tmdb.org/3/search/person?api_key=49654d7090b510dbd0733c03917c7caf&query="+_actor));
            var str = await resp.Content.ReadAsStringAsync();
            var x = JsonConvert.DeserializeObject(str);

            var Collection = JObject.Parse(str)["results"].ToObject<ObservableCollection<PersonInfo>>();
            return Collection[0].Id;
        }

        protected async Task<List<PersonInfoRole>> GetMoviesByActor(string _actor)
        {
            PersonInfo info = new PersonInfo();
            var hc = new HttpClient();

            var resp = await hc.GetAsync(new Uri("http://api.tmdb.org/3/search/person?api_key=49654d7090b510dbd0733c03917c7caf&query=" + _actor));
            var str = await resp.Content.ReadAsStringAsync();
            var x = JsonConvert.DeserializeObject(str);

            var Collection = JObject.Parse(str)["results"].ToObject<ObservableCollection<PersonInfo>>();

            return Collection[0].KnownFor.ToList<PersonInfoRole>();
        }

        protected async Task<Movie> GetMovieByID(int _id)
        {
            ApiQueryResponse<Movie> Movie = await MovieApi.FindByIdAsync(_id);
            return Movie.Item;
        }
    }
}
