using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task AddActor(Guid filmId, Guid actorId)
        {
            var film = _context.Films.Find(filmId);
            var actor = _context.Actors.Find(actorId);
            if(film is null || actor is null)
                throw new InvalidOperationException("Hatalı giriş");
            FilmActor fa = new FilmActor();
            fa.FilmId = filmId;
            fa.ActorId = actorId;
            _context.FilmActors.Add(fa);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Actor> GetAllActors(Guid filmId)
        {
            var result = _context.Actors.Where(item => item.Films.Any(x => x.FilmId == filmId));
            return result;

        }
    }
}