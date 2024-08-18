using System;
using GameStore.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.api.Data
{
    // The GameStoreContext class inherits from DbContext, which is a part of Entity Framework Core.
    // It represents a session with the database, allowing us to query and save data.
    public class GameStoreContext : DbContext
    {
        // The constructor of GameStoreContext, which takes DbContextOptions<GameStoreContext> as an argument.
        // These options specify the configuration (like the database provider) for the DbContext.
        public GameStoreContext(DbContextOptions<GameStoreContext> options) 
            : base(options)  // Calls the base class constructor with the provided options.
        {
        }

        // DbSet<Game> represents the collection of Game entities in the database.
        // It allows querying and saving instances of the Game entity to the database.
        public DbSet<Game> Games => Set<Game>();

        // DbSet<Genre> represents the collection of Genre entities in the database.
        // It allows querying and saving instances of the Genre entity to the database.
        public DbSet<Genre> Genres => Set<Genre>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new { Id = 1, Name = "Fighting"},
                new { Id = 2, Name = "Roleplaying"},
                new { Id = 3, Name = "Sports"},
                new { Id = 4, Name = "Racing"},
                new { Id = 5, Name = "Kids and Family"}
            );
        }
    }
}
