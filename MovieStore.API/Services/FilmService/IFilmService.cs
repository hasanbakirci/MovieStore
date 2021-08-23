using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.FilmRequest;
using MovieStore.API.Models;

namespace MovieStore.API.Services.FilmService
{
    public interface IFilmService
    {
        Task Add(CreateFilmRequest request);
        Task<IEnumerable<FilmDto>> GetAll();
        Task<FilmDto> Get(Guid id);
        Task Delete(Guid id);
        Task Update(Guid id, UpdateFilmRequest request);
        Task AddActor(Guid filmId, Guid actorId);
        IEnumerable<FilmsOfActorsDto> GetAllActors(Guid filmId);
    }
}