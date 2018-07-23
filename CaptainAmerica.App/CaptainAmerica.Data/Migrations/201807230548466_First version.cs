namespace CaptainAmerica.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firstversion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArchivoComentario",
                c => new
                    {
                        IdArchivoComentario = c.Int(nullable: false, identity: true),
                        ArchivoComentarioDescr = c.String(),
                        ProyectoArchivo_IdProyectoArchivo = c.Int(),
                    })
                .PrimaryKey(t => t.IdArchivoComentario)
                .ForeignKey("dbo.ProyectoArchivo", t => t.ProyectoArchivo_IdProyectoArchivo)
                .Index(t => t.ProyectoArchivo_IdProyectoArchivo);
            
            CreateTable(
                "dbo.ProyectoArchivo",
                c => new
                    {
                        IdProyectoArchivo = c.Int(nullable: false, identity: true),
                        NombreArchivo = c.String(maxLength: 75),
                        URLGuardado = c.String(maxLength: 255),
                        FechaCreacion = c.DateTime(nullable: false),
                        Proyecto_IdProyecto = c.Int(),
                    })
                .PrimaryKey(t => t.IdProyectoArchivo)
                .ForeignKey("dbo.Proyecto", t => t.Proyecto_IdProyecto)
                .Index(t => t.Proyecto_IdProyecto);
            
            CreateTable(
                "dbo.Proyecto",
                c => new
                    {
                        IdProyecto = c.Int(nullable: false, identity: true),
                        NombreProyecto = c.String(maxLength: 75),
                        FechaCreacion = c.DateTime(nullable: false),
                        Cliente_IdCliente = c.Int(),
                        ProyectoCategoria_IdCategoriaProyecto = c.Int(),
                    })
                .PrimaryKey(t => t.IdProyecto)
                .ForeignKey("dbo.Cliente", t => t.Cliente_IdCliente)
                .ForeignKey("dbo.ProyectoCategoria", t => t.ProyectoCategoria_IdCategoriaProyecto)
                .Index(t => t.Cliente_IdCliente)
                .Index(t => t.ProyectoCategoria_IdCategoriaProyecto);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        NombreCliente = c.String(maxLength: 75),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.ProyectoCategoria",
                c => new
                    {
                        IdCategoriaProyecto = c.Int(nullable: false, identity: true),
                        NombreCategoriaProyecto = c.String(maxLength: 50),
                        DescrCategoriaProyecto = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.IdCategoriaProyecto);
            
            CreateTable(
                "dbo.ProyectoMiembro",
                c => new
                    {
                        IdProyectoMiembro = c.Int(nullable: false, identity: true),
                        MiembroPermiso = c.String(maxLength: 1),
                        Proyecto_IdProyecto = c.Int(),
                        Usuario_IdUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.IdProyectoMiembro)
                .ForeignKey("dbo.Proyecto", t => t.Proyecto_IdProyecto)
                .ForeignKey("dbo.Usuario", t => t.Usuario_IdUsuario)
                .Index(t => t.Proyecto_IdProyecto)
                .Index(t => t.Usuario_IdUsuario);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        CodigoUsuario = c.String(maxLength: 50),
                        NombreUsuario = c.String(maxLength: 75),
                        FechaCreacion = c.DateTime(nullable: false),
                        Rol_IdRol = c.Int(),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .ForeignKey("dbo.Rol", t => t.Rol_IdRol)
                .Index(t => t.Rol_IdRol);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        IdRol = c.Int(nullable: false, identity: true),
                        NombreRol = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.IdRol);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProyectoMiembro", "Usuario_IdUsuario", "dbo.Usuario");
            DropForeignKey("dbo.Usuario", "Rol_IdRol", "dbo.Rol");
            DropForeignKey("dbo.ProyectoMiembro", "Proyecto_IdProyecto", "dbo.Proyecto");
            DropForeignKey("dbo.ArchivoComentario", "ProyectoArchivo_IdProyectoArchivo", "dbo.ProyectoArchivo");
            DropForeignKey("dbo.ProyectoArchivo", "Proyecto_IdProyecto", "dbo.Proyecto");
            DropForeignKey("dbo.Proyecto", "ProyectoCategoria_IdCategoriaProyecto", "dbo.ProyectoCategoria");
            DropForeignKey("dbo.Proyecto", "Cliente_IdCliente", "dbo.Cliente");
            DropIndex("dbo.Usuario", new[] { "Rol_IdRol" });
            DropIndex("dbo.ProyectoMiembro", new[] { "Usuario_IdUsuario" });
            DropIndex("dbo.ProyectoMiembro", new[] { "Proyecto_IdProyecto" });
            DropIndex("dbo.Proyecto", new[] { "ProyectoCategoria_IdCategoriaProyecto" });
            DropIndex("dbo.Proyecto", new[] { "Cliente_IdCliente" });
            DropIndex("dbo.ProyectoArchivo", new[] { "Proyecto_IdProyecto" });
            DropIndex("dbo.ArchivoComentario", new[] { "ProyectoArchivo_IdProyectoArchivo" });
            DropTable("dbo.Rol");
            DropTable("dbo.Usuario");
            DropTable("dbo.ProyectoMiembro");
            DropTable("dbo.ProyectoCategoria");
            DropTable("dbo.Cliente");
            DropTable("dbo.Proyecto");
            DropTable("dbo.ProyectoArchivo");
            DropTable("dbo.ArchivoComentario");
        }
    }
}
