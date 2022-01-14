using System.Collections.Generic;

namespace SuncoastMovies
{
    public class Rating
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
// Add this inside `SuncoastMoviesContext`

// Define a Ratings property that is a DbSet.
