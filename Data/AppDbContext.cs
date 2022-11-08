using Microsoft.EntityFrameworkCore;
using MovieWeb.Models;

namespace MovieWeb.Data
{

    //Name: movies-db-001
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provider_Movie>().HasKey(key => new
            {
                key.ProviderId,
                key.MovieId
            });

            modelBuilder.Entity<Provider_Movie>().HasOne(m => m.Movie).WithMany(p => p.Providers).HasForeignKey(m => m.MovieId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Movie>? Movies { get; set; }
        public DbSet<Providers>? providers { get; set; }
        public DbSet<Provider_Movie>? providerMovie { get; set; }

    }
}
