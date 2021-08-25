using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.API.Models;

namespace MovieStore.API.Repository
{
    public interface IMovieStoreDbContext
    {
        DbSet<Film> Films {get; init;}
        DbSet<Actor> Actors {get; init;}
        DbSet<FilmActor> FilmActors { get; init; }
        DbSet<Director> Directors { get; set; }
        DbSet<FilmDirector> FilmDirectors { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}