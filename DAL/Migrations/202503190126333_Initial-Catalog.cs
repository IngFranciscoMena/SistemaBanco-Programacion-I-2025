namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCatalog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargos",
                c => new
                    {
                        IdCargo = c.Int(nullable: false, identity: true),
                        nombre_cargo = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdCargo);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        nombre_cliente = c.String(nullable: false, maxLength: 100),
                        apellido_cliente = c.String(nullable: false, maxLength: 100),
                        dni_cliente = c.String(nullable: false, maxLength: 15),
                        telefono_cliente = c.String(maxLength: 20),
                        IdEstado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente)
                .ForeignKey("dbo.Estados", t => t.IdEstado)
                .Index(t => t.IdEstado);
            
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        IdEstado = c.Int(nullable: false, identity: true),
                        nombre_estado = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdEstado);
            
            CreateTable(
                "dbo.Cuentas",
                c => new
                    {
                        IdCuentas = c.Int(nullable: false, identity: true),
                        IdCliente = c.Int(nullable: false),
                        IdTipoCuenta = c.Int(nullable: false),
                        saldo_cuenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdEstado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCuentas)
                .ForeignKey("dbo.Clientes", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.Estados", t => t.IdEstado)
                .ForeignKey("dbo.TipoCuentas", t => t.IdTipoCuenta, cascadeDelete: true)
                .Index(t => t.IdCliente)
                .Index(t => t.IdTipoCuenta)
                .Index(t => t.IdEstado);
            
            CreateTable(
                "dbo.TipoCuentas",
                c => new
                    {
                        IdTipoCuenta = c.Int(nullable: false, identity: true),
                        nombre_tipo_cuenta = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdTipoCuenta);
            
            CreateTable(
                "dbo.Departamentos",
                c => new
                    {
                        IdDepartamento = c.Int(nullable: false, identity: true),
                        nombre_departamento = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdDepartamento);
            
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        IdEmpleado = c.Int(nullable: false, identity: true),
                        nombre_empleado = c.String(nullable: false, maxLength: 100),
                        apellido_empleado = c.String(nullable: false, maxLength: 100),
                        dni_empleado = c.String(nullable: false, maxLength: 15),
                        IdCargo = c.Int(nullable: false),
                        IdDepartamento = c.Int(nullable: false),
                        IdEstado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdEmpleado)
                .ForeignKey("dbo.Cargos", t => t.IdCargo, cascadeDelete: true)
                .ForeignKey("dbo.Departamentos", t => t.IdDepartamento, cascadeDelete: true)
                .ForeignKey("dbo.Estados", t => t.IdEstado)
                .Index(t => t.IdCargo)
                .Index(t => t.IdDepartamento)
                .Index(t => t.IdEstado);
            
            CreateTable(
                "dbo.TipoTransacciones",
                c => new
                    {
                        IdTipoTransaccion = c.Int(nullable: false, identity: true),
                        nombre_tipo_transaccion = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdTipoTransaccion);
            
            CreateTable(
                "dbo.Transacciones",
                c => new
                    {
                        IdTransacciones = c.Int(nullable: false, identity: true),
                        IdCuenta = c.Int(nullable: false),
                        IdTipoTransaccion = c.Int(nullable: false),
                        monto_transaccion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fecha_transaccion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdTransacciones)
                .ForeignKey("dbo.Cuentas", t => t.IdCuenta, cascadeDelete: true)
                .ForeignKey("dbo.TipoTransacciones", t => t.IdTipoTransaccion, cascadeDelete: true)
                .Index(t => t.IdCuenta)
                .Index(t => t.IdTipoTransaccion);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transacciones", "IdTipoTransaccion", "dbo.TipoTransacciones");
            DropForeignKey("dbo.Transacciones", "IdCuenta", "dbo.Cuentas");
            DropForeignKey("dbo.Empleados", "IdEstado", "dbo.Estados");
            DropForeignKey("dbo.Empleados", "IdDepartamento", "dbo.Departamentos");
            DropForeignKey("dbo.Empleados", "IdCargo", "dbo.Cargos");
            DropForeignKey("dbo.Cuentas", "IdTipoCuenta", "dbo.TipoCuentas");
            DropForeignKey("dbo.Cuentas", "IdEstado", "dbo.Estados");
            DropForeignKey("dbo.Cuentas", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "IdEstado", "dbo.Estados");
            DropIndex("dbo.Transacciones", new[] { "IdTipoTransaccion" });
            DropIndex("dbo.Transacciones", new[] { "IdCuenta" });
            DropIndex("dbo.Empleados", new[] { "IdEstado" });
            DropIndex("dbo.Empleados", new[] { "IdDepartamento" });
            DropIndex("dbo.Empleados", new[] { "IdCargo" });
            DropIndex("dbo.Cuentas", new[] { "IdEstado" });
            DropIndex("dbo.Cuentas", new[] { "IdTipoCuenta" });
            DropIndex("dbo.Cuentas", new[] { "IdCliente" });
            DropIndex("dbo.Clientes", new[] { "IdEstado" });
            DropTable("dbo.Transacciones");
            DropTable("dbo.TipoTransacciones");
            DropTable("dbo.Empleados");
            DropTable("dbo.Departamentos");
            DropTable("dbo.TipoCuentas");
            DropTable("dbo.Cuentas");
            DropTable("dbo.Estados");
            DropTable("dbo.Clientes");
            DropTable("dbo.Cargos");
        }
    }
}
