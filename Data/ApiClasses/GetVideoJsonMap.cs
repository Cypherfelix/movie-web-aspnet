namespace MovieWeb.Data.ApiClasses
{
#pragma warning disable IDE1006 // Naming Styles
    public class ResultVideo
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
        public DateTime published_at
        {
            get; set;
        }
        public string? id
        {
            get; set;
        }
    }

    public class GetVideoJsonMap
    {
        public int id
        {
            get; set;
        }
        public List<ResultVideo>? results
        {
            get; set;
        }
    }
}
