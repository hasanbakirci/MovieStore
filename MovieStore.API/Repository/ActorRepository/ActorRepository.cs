using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.API.Models;

namespace MovieStore.API.Repository.ActorRepository
{
    public class ActorRepository : IActorRepository
    {
        private readonly IMovieStoreDbContext _context;

        public ActorRepository(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public async Task Add(Actor actor)
        {
            _context.Actors.Add(actor);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var result = _context.Actors.Find(id);
            if(result is null)
                throw new InvalidOperationException("Actor bulunamadı.");
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<Actor> Get(Guid id)
        {
            return await _context.Actors.FindAsync();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            return await _context.Actors.ToListAsync();
        }

        public IEnumerable<Film> GetAllFilms(Guid actorId)
        {
            var result = _context.Films.Where(item => item.Actors.Any(x => x.ActorId == actorId));
            return result;
        }

        public async Task Update(Guid id, Actor actor)
        {
            var result = _context.Actors.Find(id);
            if(result is null)
                throw new InvalidOperationException("Actor bulunamadı.");
            result.Name = actor.Name != default ? actor.Name : result.Name;
            result.Surname = actor.Surname != default ? actor.Surname : result.Surname;
            await _context.SaveChangesAsync();
        }
    }
}