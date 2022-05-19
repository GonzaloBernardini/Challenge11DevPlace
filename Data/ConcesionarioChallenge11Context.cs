using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConcesionarioChallenge11.Models;

namespace ConcesionarioChallenge11.Data
{
    public class ConcesionarioChallenge11Context : DbContext
    {
        public ConcesionarioChallenge11Context (DbContextOptions<ConcesionarioChallenge11Context> options)
            : base(options)
        {
        }

        public DbSet<ConcesionarioChallenge11.Models.Concesionario> Concesionario { get; set; }

        public DbSet<ConcesionarioChallenge11.Models.Unidades> Unidades { get; set; }

        //public DbSet<Login> Login { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Login>(entidad =>
        //    {
        //        entidad.ToTable("Login");

        //        entidad.HasKey(l => l.IdLogin);

        //        entidad.Property(l => l.Usuario).IsRequired();

        //        entidad.Property(l => l.Password).IsRequired();
        //    });
        //}
    }
}
