using System;

namespace MovieStore.API.Models
{
    public class FilmDirector
    {
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
        public Guid DirectorId { get; set; }
        public Director Director { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}