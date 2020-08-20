using Microsoft.EntityFrameworkCore;

namespace MyMoviesApi.Data
{
    public class MoviesContext : DbContext
    {
        // Constructor is required
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) { }

        // THe DbSet with movie model
        public virtual DbSet<Movie> Movies { get; set; }

        // For getting the default connection?
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection");
            }
        }
    }
}

//System.ArgumentException: 'AddDbContext was called with configuration, but the context type 'MoviesContext' only declares a parameterless constructor.
//This means that the configuration passed to AddDbContext will never be used.
//If configuration is passed to AddDbContext,
//then 'MoviesContext' should declare a constructor that accepts a DbContextOptions<MoviesContext> and must pass it to the base constructor for DbContext.'
