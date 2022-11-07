using MovieWeb.Data.ApiClasses;
using Newtonsoft.Json;

namespace MovieWeb.Data
{
    public class AppDbInitializer
    {


        public List<MovieJsonMap> myMovies = new();
        private static AppDbInitializer instance;

        public AppDbInitializer()
        {
            TrendingMovies = new();
            TopRated = new();
            NetFlixOriginals = new();
            ActionMovies = new();
            ComedyMovies = new();
            HorrorMovies = new();
        }

        public List<MovieJsonMap> TrendingMovies
        {
            get; set;
        }

        public List<MovieJsonMap> TopRated
        {
            get; set;
        }

        public List<MovieJsonMap> NetFlixOriginals
        {
            get; set;
        }

        public List<MovieJsonMap> ActionMovies
        {
            get; set;
        }
        public List<MovieJsonMap> ComedyMovies
        {
            get; set;
        }
        public List<MovieJsonMap> HorrorMovies
        {
            get; set;
        }

        public static AppDbInitializer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppDbInitializer();
                }

                return instance;

            }

        }



        private const string BASE_URL = "https://api.themoviedb.org/3";
        private const string API = "e540c866037d38974a34a29699fdb59d";
        private const string IMAGE_BASE = "https://image.tmdb.org/t/p/w500";
        public async Task Seed(IApplicationBuilder app)
        {
            Console.WriteLine("Here");
            MoviesResultJsonMap list = await FetchMovies("/trending/all/week?api_key=");

            List<MovieResult> mr = list.results;
            for (int i = 0; i < mr.Count; i++)
            {
                MovieResult m = mr.ElementAt(i);
                MovieJsonMap mo = await FetchMovie(m);
                myMovies.Add(mo);
            }

            TrendingMovies = myMovies;
            Console.WriteLine(myMovies.Count);

        }

        public MovieJsonMap GetMovieById(int id)
        {
            for (int i = 0; i < TrendingMovies.Count; i++)
            {
                var movie = TrendingMovies[i];
                if (movie.id == id)
                {
                    return movie;
                }
            }

            return TrendingMovies.ElementAt(0);
        }

        public async Task<MoviesResultJsonMap?> FetchMovies(string url)
        {
            url = BASE_URL + url + API;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    MoviesResultJsonMap? movies = JsonConvert.DeserializeObject<MoviesResultJsonMap>(data);
                    return movies;
                }
                else
                {
                    Console.WriteLine("Error making request");
                }
            }

            return null;
        }

        public async Task<MovieJsonMap> FetchMovie(MovieResult m)
        {
            string url = $"{BASE_URL}/{(m.media_type.Equals("tv") ? "tv" : "movie")}/{m.id}?api_key={API}&append_to_response=videos,images";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    MovieJsonMap movie = JsonConvert.DeserializeObject<MovieJsonMap>(data);

                    MovieProviderJsonMap? providerJsonMap = await GetMovieProvidersMap(m);
                    movie.providers = providerJsonMap;
                    movie.backdrop_path = $"{IMAGE_BASE}{(movie.backdrop_path == null ? movie.poster_path : movie.backdrop_path)}";

                    movie.title = (movie.title == null ? movie.name : movie.title);
                    return movie;
                }
                else
                {
                    Console.WriteLine("Error making request");
                }
            }

            return null;
        }

        private async Task<MovieProviderJsonMap?> GetMovieProvidersMap(MovieResult? movie)
        {

            string url = $"{BASE_URL}/{(movie.media_type.Equals("tv") ? "tv" : "movie")}/{movie.id}/watch/providers?api_key={API}";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    MovieProviderJsonMap? provider = JsonConvert.DeserializeObject<MovieProviderJsonMap>(data);
                    return provider;
                }
                else
                {
                    Console.WriteLine("Error making request");
                }
            }

            return null;
        }

        public async Task ConsumeExternalAPI()
        {
            string url = BASE_URL + "/trending/all/week?api_key=" + API;
            string test = "https://api.themoviedb.org/3/movie/550?api_key=e540c866037d38974a34a29699fdb59d";
            //url = test;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();

                    MoviesResultJsonMap movies = JsonConvert.DeserializeObject<MoviesResultJsonMap>(data);
                    //Trace.WriteLine(jsonString);
                    Console.WriteLine(movies.results.Count);
                }
                else
                {
                    Console.WriteLine("Error making request");
                }
            }
        }

    }
}
