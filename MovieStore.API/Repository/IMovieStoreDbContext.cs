using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.API.Models;

namespace MovieStore.API.Repository
{
    public interface IMovieStoreDbContext
    {
        DbSet<Film> Films {get; init;}
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}