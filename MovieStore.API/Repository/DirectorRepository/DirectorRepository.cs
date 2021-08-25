using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.API.Models;

namespace MovieStore.API.Repository.DirectorRepository
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly IMovieStoreDbContext _context;

        public DirectorRepository(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public async Task Add(Director director)
        {
            _context.Directors.Add(director);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var director = _context.Directors.Find(id);
            if(director is null)
                throw new InvalidOperationException("Director bulunamadı");
            _context.Directors.Remove(director);
            await _context.SaveChangesAsync();
        }

        public async Task<Director> Get(Guid id)
        {
            return await _context.Directors.FindAsync(id);
        }

        public async Task<IEnumerable<Director>> GetAll()
        {
            return await _context.Directors.ToListAsync();
        }

        public IEnumerable<Film> GetAllFilms(Guid directorId)
        {
            var result = _context.Films.Where(item => item.Directors.Any(x => x.DirectorId == directorId));
            return result;
        }

        public async Task Update(Guid id, Director director)
        {
            var result = _context.Directors.Find(id);
            if(director is null)
                throw new InvalidOperationException("Director bulunamadı");
            result.Name = director.Name != default ? director.Name : result.Name; 
            result.Surname = director.Surname != default ? director.Surname : result.Surname;
            await _context.SaveChangesAsync();
        }
    }
}