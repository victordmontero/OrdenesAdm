using OrdenesAdmCL.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesAdmCL.Contexto
{
    public class Context : DbContext
    {
        public Context()
            : base(ConfigurationManager.ConnectionStrings["Ordenes"].ConnectionString)
        {
            Database.SetInitializer<Context>(null);
        }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Suplidor> Suplidores { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Producto>().ToTable("Productos");
            modelBuilder.Entity<Rol>().ToTable("Roles");
            modelBuilder.Entity<Suplidor>().ToTable("Suplidores");
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Ignore<BaseEntity>();
            modelBuilder.Ignore<Persona>();

            modelBuilder.Entity<Producto>().HasRequired(c => c.Categoria)
                .WithMany(p => p.Productos)
                .HasForeignKey(c => c.CategoriaId);

            modelBuilder.Entity<Usuario>().HasRequired(u => u.Rol)
                .WithMany(r => r.Usuarios)
                .HasForeignKey(u => u.RolId);

            modelBuilder.Entity<Producto>().HasRequired(c => c.Suplidor)
                .WithMany(s => s.Productos)
                .HasForeignKey(c => c.SuplidorId);
        }
    }
}
