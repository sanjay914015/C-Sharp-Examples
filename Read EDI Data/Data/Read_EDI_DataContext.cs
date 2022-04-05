using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Read_EDI_Data.Models;

namespace Read_EDI_Data.Data
{
    public class Read_EDI_DataContext : DbContext
    {
        public Read_EDI_DataContext (DbContextOptions<Read_EDI_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Read_EDI_Data.Models.Ports> Ports { get; set; }
    }
}
