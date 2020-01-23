using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace THE_SNAP_WEB.Models
{
    public class DbContext_Model
    {
        public class THE_SNAP_WEB_Context : DbContext
        {
            public THE_SNAP_WEB_Context(DbContextOptions<THE_SNAP_WEB_Context> options)
                : base(options)
            { }
            public DbSet<Teams> Teams { get; set; }

            public DbSet<Players> Players { get; set; }
        }
    }
}
