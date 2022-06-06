using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class GQL_DbContext : DbContext
    {
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Device> Devices { get; set; }

        public GQL_DbContext(DbContextOptions<GQL_DbContext> options)
            : base(options)
        {
        }
    }
}
