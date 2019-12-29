using Docker.Webapi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docker.Webapi.Infrastructure
{
    public class WebApiDbContext : DbContext
    {
        public WebApiDbContext(DbContextOptions<WebApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Inventory> Inventory { get; set; }
    }
}
