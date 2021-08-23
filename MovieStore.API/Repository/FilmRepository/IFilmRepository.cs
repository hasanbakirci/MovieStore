using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieStore.API.Models;

namespace MovieStore.API.Repository.FilmRepository
{
    public interface IFilmRepository
    {
        Task Add(Film film);
        Task<IEnumerable<Film>> GetAll();
        Task<Film> Get(Guid id);
        Task Delete(Guid id);
        Task Update(Guid id, Film film);
        Task AddActor(Guid filmId, Guid actorId);
        IEnumerable<Actor> GetAllActors(Guid filmId);
    }
}