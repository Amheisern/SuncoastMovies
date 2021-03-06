using Microsoft.EntityFrameworkCore;

namespace SuncoastMovies
{
    // Define a database context for our Suncoast Movies database.
    // It derives from (has a parent of) DbContext so we get all the
    // abilities of a database context from EF Core.
    class SuncoastMoviesContext : DbContext
    {
        // Define a movies property that is a DbSet.
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Actor> Actors { get; set; }
        // Define a method required by EF that will configure our connection
        // to the database.
        //
        // DbContextOptionsBuilder is provided to us. We then tell that object
        // we want to connect to a postgres database named suncoast_movies on
        // our local machine.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost;database=SuncoastMovies");
        }
    }
}