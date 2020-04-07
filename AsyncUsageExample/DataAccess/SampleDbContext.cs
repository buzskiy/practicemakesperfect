using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncUsageExample.DataAccess.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AsyncUsageExample.DataAccess
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<SampleEntity1> SampleEntities { get; set; }
    }
}
