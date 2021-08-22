namespace MovieStore.API.Dtos.Request.FilmRequest
{
    public class CreateFilmRequest
    {
        public string Name { get; set; }
        public int GenreId { get; set; }
        public double  Price { get; set; }
    }
}