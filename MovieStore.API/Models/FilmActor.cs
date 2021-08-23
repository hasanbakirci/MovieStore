using System;

namespace MovieStore.API.Models
{
    public class FilmActor
    {
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
        public Guid ActorId { get; set; }
        public Actor Actor { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}