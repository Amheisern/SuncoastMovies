namespace SuncoastMovies
{
    class Rating
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
// Add this inside `SuncoastMoviesContext`

// Define a Ratings property that is a DbSet.
