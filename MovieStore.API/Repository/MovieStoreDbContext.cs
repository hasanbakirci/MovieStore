using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.API.Models;

namespace MovieStore.API.Repository
{
    public class MovieStoreDbContext : DbContext, IMovieStoreDbContext
    {
        public MovieStoreDbContext(DbContextOptions<MovieStoreDbContext> options) : base(options)
        {
            
        }
        public DbSet<Film> Films { get; init; }
        public DbSet<Actor> Actors { get; init; }
        public DbSet<FilmActor> FilmActors { get; init; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmActor>()
            .HasKey(fa => new {fa.FilmId, fa.ActorId});

            modelBuilder.Entity<FilmActor>()
            .HasOne(fa => fa.Film)
            .WithMany(f => f.Actors)
            .HasForeignKey(fa => fa.FilmId);

            modelBuilder.Entity<FilmActor>()
            .HasOne(fa => fa.Actor)
            .WithMany(f => f.Films)
            .HasForeignKey(fa => fa.ActorId);
        }

    }
}