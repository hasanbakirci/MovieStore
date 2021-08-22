using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.API.Models;

namespace MovieStore.API.Repository.FilmRepository
{
    public class FilmRepository : IFilmRepository
    {
        private readonly IMovieStoreDbContext _context;

        public FilmRepository(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public async Task Add(Film film)
        {
            _context.Films.Add(film);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var result = await _context.Films.FindAsync(id);
            if (result is null)
                throw new InvalidOperationException("Film bulunamadı.");
            _context.Films.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<Film> Get(Guid id)
        {
            return await _context.Films.FindAsync(id);
        }

        public async Task<IEnumerable<Film>> GetAll()
        {
            return await _context.Films.ToListAsync();
        }

        public async Task Update(Guid id, Film film)
        {
            var result = await _context.Films.FindAsync(id);
            if (result is null)
                throw new InvalidOperationException("Film bulunamadı.");
            result.Name = film.Name != default ? film.Name : result.Name; 
            result.Price = film.Price != default ? film.Price : result.Price;
            await _context.SaveChangesAsync();
        }
    }
}