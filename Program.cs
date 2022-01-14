using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SuncoastMovies
{


    class Program
    {
        static void Main(string[] args)
        {
            // Get a new context which will connect to the database
            var context = new SuncoastMoviesContext();

            var movieCount = context.Movies.Count();
            Console.WriteLine($"There are {movieCount} movies in the database");

            var moviesWithRatings = context.Movies.Include(movie => movie.Rating);
            foreach (var movie in moviesWithRatings)
            {
                if (movie.Rating == null)
                {
                    Console.WriteLine($"There is a movie named {movie.Title} and has not been rated yet");
                }
                else
                {
                    Console.WriteLine($"There is a movie named {movie.Title} and a rating of {movie.Rating.Description}");
                }
            }
        }
    }
}
