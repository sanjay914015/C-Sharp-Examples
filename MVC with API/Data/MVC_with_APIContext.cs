using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_with_API.Models;

namespace MVC_with_API.Data
{
    public class MVC_with_APIContext : DbContext
    {
        public MVC_with_APIContext (DbContextOptions<MVC_with_APIContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_with_API.Models.Ports> Ports { get; set; }
    }
}
