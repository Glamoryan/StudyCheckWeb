using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudyCheckWeb.DataAccess.Concrete.EntityFramework.Mappings;
using StudyCheckWeb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace StudyCheckWeb.DataAccess.Concrete.EntityFramework.Contexts
{
    public class StudyCheckContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;initial catalog=StudyCheck;integrated security=true");
        }

        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Uyedetay> UyeDetay { get; set; }
        public DbSet<Yetki> Yetkiler { get; set; }
        public DbSet<Tema> Temalar { get; set; }
        public DbSet<Sinav> Sinavlar { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Calisma> Calismalar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UyeMap());
            modelBuilder.ApplyConfiguration(new UyedetayMap());
            modelBuilder.ApplyConfiguration(new YetkiMap());
            modelBuilder.ApplyConfiguration(new TemaMap());
            modelBuilder.ApplyConfiguration(new SinavMap());
            modelBuilder.ApplyConfiguration(new RolMap());
            modelBuilder.ApplyConfiguration(new DersMap());
            modelBuilder.ApplyConfiguration(new CalismaMap());
            //modelBuilder.Entity<Ders>().Property(typeof(DateTime), "datetime2");
            //modelBuilder.Entity<Rol>().Property(typeof(DateTime), "datetime2");
            //modelBuilder.Entity<Sinav>().Property(typeof(DateTime), "datetime2");
            //modelBuilder.Entity<Uyedetay>().Property(typeof(DateTime), "datetime2");
            //modelBuilder.Entity<Yetki>().Property(typeof(DateTime), "datetime2");                 
        }
    }
}
