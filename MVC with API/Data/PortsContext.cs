using Microsoft.EntityFrameworkCore;
using MVC_with_API.Models;

namespace MVC_with_API.Data
{
    public class PortsContext: DbContext
    {

        public PortsContext(DbContextOptions<PortsContext> options) : base(options)
        {

        }
        public DbSet<Ports> Port { get; set; }

    }
}
