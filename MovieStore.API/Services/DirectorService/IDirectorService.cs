using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.DirectorRequest;
using MovieStore.API.Models;

namespace MovieStore.API.Services.DirectorService
{
    public interface IDirectorService
    {
        Task Add(CreateDirectorRequest request);
        Task<IEnumerable<DirectorDto>> GetAll();
        Task<DirectorDto> Get(Guid id);
        Task Delete(Guid id);
        Task Update(Guid id,UpdateDirectorRequest request);
        IEnumerable<FilmsOfDirectorsDto> GetAllFilms(Guid directorId);
    }
}