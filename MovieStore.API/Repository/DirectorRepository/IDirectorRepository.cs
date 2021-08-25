using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieStore.API.Models;

namespace MovieStore.API.Repository.DirectorRepository
{
    public interface IDirectorRepository
    {
        Task Add(Director director);
        Task<IEnumerable<Director>> GetAll();
        Task<Director> Get(Guid id);
        Task Delete(Guid id);
        Task Update(Guid id,Director director);
        IEnumerable<Film> GetAllFilms(Guid directorId);
    }
}