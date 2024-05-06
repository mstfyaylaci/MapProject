using Entites.Concrete;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class MapContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;DataBase=MapProject; User Id=postgres; password=1201");
        }


        public DbSet<Entites.Concrete.Point> Points { get; set; }
        public DbSet<Polygon> Polygons { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasPostgresExtension("postgis");
        //    modelBuilder.Entity<CustomPolygon>()
        //        .Property(p => p.Polygon)
        //        .HasConversion<double>();

        //}

        



    }
}
