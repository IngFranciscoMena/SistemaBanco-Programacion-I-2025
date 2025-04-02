namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agregar_Usuarios_y_Roles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        IdRol = c.Int(nullable: false, identity: true),
                        nombre_roles = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdRol);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        correo_usuario = c.String(nullable: false, maxLength: 100),
                        contraseña_usuario = c.String(nullable: false, maxLength: 255),
                        IdRol = c.Int(nullable: false),
                        IdCliente = c.Int(),
                        IdEmpleado = c.Int(),
                        Cliente_IdCliente = c.Int(),
                        Empleado_IdEmpleado = c.Int(),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .ForeignKey("dbo.Clientes", t => t.Cliente_IdCliente)
                .ForeignKey("dbo.Empleados", t => t.Empleado_IdEmpleado)
                .ForeignKey("dbo.Roles", t => t.IdRol, cascadeDelete: true)
                .Index(t => t.IdRol)
                .Index(t => t.Cliente_IdCliente)
                .Index(t => t.Empleado_IdEmpleado);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "IdRol", "dbo.Roles");
            DropForeignKey("dbo.Usuarios", "Empleado_IdEmpleado", "dbo.Empleados");
            DropForeignKey("dbo.Usuarios", "Cliente_IdCliente", "dbo.Clientes");
            DropIndex("dbo.Usuarios", new[] { "Empleado_IdEmpleado" });
            DropIndex("dbo.Usuarios", new[] { "Cliente_IdCliente" });
            DropIndex("dbo.Usuarios", new[] { "IdRol" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Roles");
        }
    }
}
