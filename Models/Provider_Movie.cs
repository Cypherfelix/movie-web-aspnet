namespace MovieWeb.Models
{
    public class Provider_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ProviderId { get; set; }
        public Providers Provider { get; set; }
    }
}
