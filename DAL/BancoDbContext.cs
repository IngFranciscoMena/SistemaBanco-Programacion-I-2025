using EL;
using System;
using System.Data.Entity;
using System.Linq;
using System.Xml;

namespace DAL
{
    public class BancoDbContext : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'BancoDbContext' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'DAL.BancoDbContext' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'BancoDbContext'  en el archivo de configuración de la aplicación.
        public BancoDbContext()
            : base("name=BancoDbContext")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cuenta> Cuentas { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<TipoCuenta> TipoCuentas { get; set; }
        public virtual DbSet<TipoTransaccion> TipoTransacciones { get; set; }
        public virtual DbSet<Transaccion> Transacciones { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Rol> Roles { get; set; } 


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Deshabilitar cascada en Cliente, Cuenta y Empleado
            modelBuilder.Entity<Cliente>()
                .HasRequired(c => c.Estado)
                .WithMany()
                .HasForeignKey(c => c.IdEstado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuenta>()
                .HasRequired(c => c.Estado)
                .WithMany()
                .HasForeignKey(c => c.IdEstado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .HasRequired(c => c.Estado)
                .WithMany()
                .HasForeignKey(c => c.IdEstado)
                .WillCascadeOnDelete(false);

            // Deshabilitar valor requerido en fk de Usuario para Empleado y Cliente
            modelBuilder.Entity<Usuario>()
                .HasOptional(u => u.Cliente)
                .WithOptionalDependent()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasOptional(u => u.Empleado)
                .WithOptionalDependent()
                .WillCascadeOnDelete(false);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}