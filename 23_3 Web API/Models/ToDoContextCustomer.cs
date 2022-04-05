using Microsoft.EntityFrameworkCore;
namespace _23_3_Web_API.Models
{
    public class ToDoContextCustomer: ToDoContext
    {
        public ToDoContextCustomer(DbContextOptions<ToDoContext> options) : base(options)
        {

        }
        public DbSet<ToDoCustomer> TodoCustomers { get; set; }
    }
}
