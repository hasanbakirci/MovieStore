namespace MovieStore.API.Dtos.Request.FilmRequest
{
    public class UpdateFilmRequest
    {
        public string Name { get; set; }
        public int GenreId { get; set; }
    }
}