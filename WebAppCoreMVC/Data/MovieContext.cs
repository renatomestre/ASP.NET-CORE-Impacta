using Microsoft.EntityFrameworkCore;
using WebAppCoreMVC.Models;

namespace WebAppCoreMVC.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; } = null!;
    }
}
