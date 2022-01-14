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

            var moviesWithRatingsRolesAndActors = context.Movies.
                                        // from our movie, please include the associated Rating object
                                        Include(movie => movie.Rating).
                                        // ... and from our movie, please include the associated Roles LIST
                                        Include(movie => movie.Roles).
                                        // THEN for each of roles, please include the associated Actor object
                                        ThenInclude(role => role.Actor);
            foreach (var movie in moviesWithRatingsRolesAndActors)
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
