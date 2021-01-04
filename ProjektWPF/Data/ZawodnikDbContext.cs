using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektWPF.Data
{
   public class ZawodnikDbContext : DbContext
    {
        public DbSet<Zawodnik> Zawodnicy { get; set; }
        public DbSet<Rozgrywka> Rozgrywki { get; set; }
        public DbSet<Druzyna> Druzyny { get; set; }

        public ZawodnikDbContext(DbContextOptions<ZawodnikDbContext> options) : base(options)
            {
                Database.EnsureCreated();
            }
      
      
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Zawodnik>();
            modelBuilder.Entity<Rozgrywka>();
            modelBuilder.Entity<Druzyna>();
            base.OnModelCreating(modelBuilder);
            }
           
        }
    }


