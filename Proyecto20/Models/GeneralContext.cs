using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Proyecto20.Models
{
   
    public class GeneralContext: DbContext
    {
        public GeneralContext()

           : base("SERVERPROYECTOS")
        {

        }
        public DbSet<PEDetalle> PEDetalles { get; set; }
        public DbSet<PEntrada> PEntradas { get; set; }
        public DbSet<Presentacion> Presentaciones { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Almacen> Almacenes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PEntrada>().HasRequired(x => x.Sucursales);
            modelBuilder.Entity<PEntrada>().HasRequired(x => x.Proveedores);
            modelBuilder.Entity<Producto>().HasRequired(x => x.Presentaciones);
            modelBuilder.Entity<PEDetalle>().HasRequired(x => x.Productos);
            modelBuilder.Entity<Almacen>().HasRequired(x => x.Proveedores);
            modelBuilder.Entity<Almacen>().HasRequired(x => x.Presentaciones);
            modelBuilder.Entity<Almacen>().HasRequired(x => x.Productos);

        }
    
       
    }
}