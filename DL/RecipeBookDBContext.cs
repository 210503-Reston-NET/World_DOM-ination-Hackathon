using System;
using Microsoft.EntityFrameworkCore;
using Models;
namespace DL
{
    public class RecipeBookDBContext : DbContext
    {
        public RecipeBookDBContext(DbContextOptions options) : base(options)
        {

        }
        protected RecipeBookDBContext()
        {

        }
         public DbSet<Recipe> Recipes { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
                .Property(recipe => recipe.ID).ValueGeneratedOnAdd();
            modelBuilder.Entity<Ingredient>()
                .Property(recipe => recipe.ID).ValueGeneratedOnAdd();
        }
    }
}
