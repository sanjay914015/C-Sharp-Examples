using Read_EDI_Data.Models;
using Microsoft.EntityFrameworkCore;


namespace Read_EDI_Data.Data
{
    public class PortContext: DbContext
    {
        public PortContext(DbContextOptions<PortContext> options) : base(options)
        {

        }
        public DbSet<Ports> Port { get; set; }
    }
}
