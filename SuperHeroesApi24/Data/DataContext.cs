using Microsoft.EntityFrameworkCore;
using SuperHeroesApi24.Entities;

namespace SuperHeroesApi24.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes { get; set; } 
    }
}
