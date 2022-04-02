using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Sistema_tienda_online.Models
{
    public partial class BDTiendaContext : IdentityDbContext
    {
        public BDTiendaContext()
        {
        }

        public BDTiendaContext(DbContextOptions<BDTiendaContext> options)
            : base(options)
        {
        }

        public  DbSet<Categoria> Categoria { get; set; }
        public  DbSet<Detalle> Detalle { get; set; }
        public  DbSet<Factura> Factura { get; set; }
        public  DbSet<Producto> Producto { get; set; }
        public  DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Server=DESKTOP-OFGK424\\SQLEXPRESS;DataBase=BDTienda;Trusted_Connection=True");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
