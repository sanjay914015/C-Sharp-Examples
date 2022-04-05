using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5.Data
{
    public class MvcMovieContext: DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) :base(options)
        {

        }
        public DbSet<Movies> Movies { get; set; }
    }
}
