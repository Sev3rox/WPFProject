using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektWPF.Data
{
   public class ZawodnikDbContext : DbContext
    {
        public DbSet<Zawodnik> Zawodnicy { get; set; }

        public ZawodnikDbContext(DbContextOptions<ZawodnikDbContext> options) : base(options)
            {
                Database.EnsureCreated();
            }
      
      
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Zawodnik>();
                base.OnModelCreating(modelBuilder);
            }
           
        }
    }


