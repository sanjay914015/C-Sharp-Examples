using Microsoft.EntityFrameworkCore;
using MvcPorts.Models;
namespace MvcPorts.Data
{
    public class PortContext: DbContext
    {
        public PortContext(DbContextOptions<PortContext> options) : base(options)
        {

        }
        public DbSet<Ports> Port { get; set; }
    }
}
