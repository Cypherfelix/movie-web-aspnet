using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Data.ApiClasses
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
#pragma warning disable IDE1006 // Naming Styles
    public class Backdrop
    {
        public double aspect_ratio
        {
            get; set;
        }
        public int height
        {
            get; set;
        }
        public string? iso_639_1
        {
            get; set;
        }
        public string? file_path
        {
            get; set;
        }
        public double vote_average
        {
            get; set;
        }
        public int vote_count
        {
            get; set;
        }
        public int width
        {
            get; set;
        }
    }

    public class Genre
    {
        public int id
        {
            get; set;
        }
        public string? name
        {
            get; set;
        }
    }

    public class Images
    {
        public List<Backdrop>? backdrops
        {
            get; set;
        }
        public List<Logo>? logos
        {
            get; set;
        }
        public List<Poster>? posters
        {
            get; set;
        }
    }

    public class Logo
    {
        public double aspect_ratio
        {
            get; set;
        }
        public int height
        {
            get; set;
        }
        public string? iso_639_1
        {
            get; set;
        }
        public string? file_path
        {
            get; set;
        }
        public double vote_average
        {
            get; set;
        }
        public int vote_count
        {
            get; set;
        }
        public int width
        {
            get; set;
        }
    }

    public class Poster
    {
        public double aspect_ratio
        {
            get; set;
        }
        public int height
        {
            get; set;
        }
        public string? iso_639_1
        {
            get; set;
        }
        public string? file_path
        {
            get; set;
        }
        public double vote_average
        {
            get; set;
        }
        public int vote_count
        {
            get; set;
        }
        public int width
        {
            get; set;
        }
    }

    public class ProductionCompany
    {
        public int id
        {
            get; set;
        }
        public string? logo_path
        {
            get; set;
        }
        public string? name
        {
            get; set;
        }
        public string? origin_country
        {
            get; set;
        }
    }

    public class ProductionCountry
    {
        public string? iso_3166_1
        {
            get; set;
        }
        public string? name
        {
            get; set;
        }
    }

    public class Result
    {
        public string? iso_639_1
        {
            get; set;
        }
        public string? iso_3166_1
        {
            get; set;
        }
        public string? name
        {
            get; set;
        }
        public string? key
        {
            get; set;
        }
        public DateTime published_at
        {
            get; set;
        }
        public string? site
        {
            get; set;
        }
        public int size
        {
            get; set;
        }
        public string? type
        {
            get; set;
        }
        public bool official
        {
            get; set;
        }
        public string? id
        {
            get; set;
        }
    }

    public class MovieJsonMap
    {
        public bool adult
        {
            get; set;
        }

        [Display(Name = "Profile Picture")]
        public string? backdrop_path
        {
            get; set;
        }
        public object? belongs_to_collection
        {
            get; set;
        }
        public int budget
        {
            get; set;
        }
        public List<Genre>? genres
        {
            get; set;
        }
        public string? homepage
        {
            get; set;
        }
        public int id
        {
            get; set;
        }
        public string? imdb_id
        {
            get; set;
        }
        public string? original_language
        {
            get; set;
        }
        public string? original_title
        {
            get; set;
        }
        public string? overview
        {
            get; set;
        }
        public double popularity
        {
            get; set;
        }

        [Display(Name = "Profile Picture")]
        public string? poster_path
        {
            get; set;
        }
        public List<ProductionCompany>? production_companies
        {
            get; set;
        }
        public List<ProductionCountry>? production_countries
        {
            get; set;
        }
        public string? release_date
        {
            get; set;
        }
        public int revenue
        {
            get; set;
        }

        [Display(Name = "Runtime")]
        public int runtime
        {
            get; set;
        }
        public List<SpokenLanguage>? spoken_languages
        {
            get; set;
        }

        [Display(Name = "Status")]
        public string? status
        {
            get; set;
        }
        public string? tagline
        {
            get; set;
        }

        [Display(Name = "Tittle")]
        public string? title
        {
            get; set;
        }

        public string? name
        {
            get; set;
        }

        public bool video
        {
            get; set;
        }
        public double vote_average
        {
            get; set;
        }
        public int vote_count
        {
            get; set;
        }
        public Videos? videos
        {
            get; set;
        }
        public Images? images
        {
            get; set;
        }

        public MovieProviderJsonMap? providers
        {
            get; set;
        }
    }

    public class SpokenLanguage
    {
        public string? english_name
        {
            get; set;
        }
        public string? iso_639_1
        {
            get; set;
        }
        public string? name
        {
            get; set;
        }
    }

    public class Videos
    {
        public List<Result>? results
        {
            get; set;
        }
    }




}
