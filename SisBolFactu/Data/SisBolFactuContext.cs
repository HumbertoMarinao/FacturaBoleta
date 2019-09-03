using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SisBolFactu.Models
{
    public class SisBolFactuContext : DbContext
    {
        public SisBolFactuContext (DbContextOptions<SisBolFactuContext> options)
            : base(options)
        {
        }

        public DbSet<SisBolFactu.Models.Categoria> Categoria { get; set; }
    }
}
