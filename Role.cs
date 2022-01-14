namespace SuncoastMovies
{
    public class Role
    {
        public int Id { get; set; }
        public string CharacterName { get; set; }
        // This is the column in the database
        public int MovieId { get; set; }
        // This is the related object we can use from our code (if properly used with Include)
        public Movie Movie { get; set; }
        // This is the column in the database
        public int ActorId { get; set; }
        // This is the related object we can use from our code (if properly used with Include)
        public Actor Actor { get; set; }

    }
}