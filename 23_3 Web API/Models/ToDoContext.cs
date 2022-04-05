using Microsoft.EntityFrameworkCore;
namespace _23_3_Web_API.Models

{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {

        }
        public DbSet<ToDoItem> TodoItems { get; set; }

    }
}

