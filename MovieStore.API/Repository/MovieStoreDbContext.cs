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
        public DbSet<Director> Directors { get; set; }
        public DbSet<FilmDirector> FilmDirectors { get; set; }
        public DbSet<Customer> Customers { get; set ; }
        public DbSet<Order> Orders { get; set; }

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

            modelBuilder.Entity<FilmDirector>()
            .HasKey(fd => new {fd.FilmId, fd.DirectorId});

            modelBuilder.Entity<FilmDirector>()
            .HasOne(fd => fd.Film)
            .WithMany(f => f.Directors)
            .HasForeignKey(fd => fd.FilmId);

            modelBuilder.Entity<FilmDirector>()
            .HasOne(fd => fd.Director)
            .WithMany(f => f.Films)
            .HasForeignKey(fd => fd.DirectorId);
            
        }

    }
}