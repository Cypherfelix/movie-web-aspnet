using MovieWeb.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Models
{
    public class Providers
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ProviderCategory Category { get; set; }
    }
}
