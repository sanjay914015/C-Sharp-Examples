using Microsoft.EntityFrameworkCore;
using MvcPorts.Models;
namespace MvcPorts.Data
{
    public class MvcPortContext: DbContext
    {
        public MvcPortContext(DbContextOptions<MvcPortContext> options): base(options)
        {
        }

        public DbSet<MvcPorts.Models.Ports> Ports { get; set; }
    }
}
