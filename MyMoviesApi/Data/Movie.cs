namespace MyMoviesApi.Data
{
    /// <summary>
    /// The movie
    /// </summary>
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string MyRating { get; set; }
        public string Size { get; set; }
        public string Quality { get; set; }
        public string Poster { get; set; }
        public string NameCheck { get; set; }
        public string YearCheck { get; set; }
        public int Votes { get; set; }
        public decimal Rating { get; set; }
        public string Language { get; set; }
        public string Plot { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
    }
}
