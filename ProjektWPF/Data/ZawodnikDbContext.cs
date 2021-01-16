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
       public DbSet<Druzyna_Rozgrywka> Druzyna_Rozgrywka{ get; set; }
        public DbSet<Wynik> Wyniki { get; set; }
        public DbSet<Zawodys> Zawodys { get; set; }
        public DbSet<Druzyna_Zawody> Druzyna_Zawody { get; set; }


        public ZawodnikDbContext(DbContextOptions<ZawodnikDbContext> options) : base(options)
            {
                Database.EnsureCreated();
            }
      
      
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Zawodnik>();
            modelBuilder.Entity<Rozgrywka>();
            modelBuilder.Entity<Druzyna>();
            modelBuilder.Entity<Druzyna_Rozgrywka>().HasKey(i => new { i.DruzynaId, i.RozgrywkaId });
            modelBuilder.Entity<Wynik>();
            modelBuilder.Entity<Zawodys>();
            modelBuilder.Entity<Druzyna_Zawody>().HasKey(i => new { i.DruzynaId, i.ZawodyId });
            base.OnModelCreating(modelBuilder);
            }
           
        }
    }


