using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Context
{
    public class MovieManagementDbContext : DbContext
    {
        public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext> options) : base(options) { }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Biography> Biographies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, FirstName = "Raisa", LastName = "Islam" },
                new Actor { Id = 2, FirstName = "Afrida", LastName = "Hasnat" },
                new Actor { Id = 3, FirstName = "Rahat", LastName = "Islam" }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "Jawan", Description = "In SKS Tower", ActorId = 1 },
                new Movie { Id = 2, Name = "MI7", Description = "In Bashundhara City", ActorId = 3 },
                new Movie { Id = 3, Name = "Surongo", Description = "In Sony Sqaure", ActorId = 2 }
                );
        }
    }
}
