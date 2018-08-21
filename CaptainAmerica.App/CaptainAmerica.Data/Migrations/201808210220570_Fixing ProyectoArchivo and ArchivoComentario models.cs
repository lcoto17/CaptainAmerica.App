namespace CaptainAmerica.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingProyectoArchivoandArchivoComentariomodels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ArchivoComentario", "ProyectoArchivo_IdProyectoArchivo", "dbo.ProyectoArchivo");
            DropForeignKey("dbo.ProyectoArchivo", "Proyecto_IdProyecto", "dbo.Proyecto");
            DropIndex("dbo.ArchivoComentario", new[] { "ProyectoArchivo_IdProyectoArchivo" });
            DropIndex("dbo.ProyectoArchivo", new[] { "Proyecto_IdProyecto" });
            RenameColumn(table: "dbo.ArchivoComentario", name: "ProyectoArchivo_IdProyectoArchivo", newName: "IdProyectoArchivo");
            RenameColumn(table: "dbo.ProyectoArchivo", name: "Proyecto_IdProyecto", newName: "IdProyecto");
            AlterColumn("dbo.ArchivoComentario", "IdProyectoArchivo", c => c.Int(nullable: false));
            AlterColumn("dbo.ProyectoArchivo", "IdProyecto", c => c.Int(nullable: false));
            CreateIndex("dbo.ArchivoComentario", "IdProyectoArchivo");
            CreateIndex("dbo.ProyectoArchivo", "IdProyecto");
            AddForeignKey("dbo.ArchivoComentario", "IdProyectoArchivo", "dbo.ProyectoArchivo", "IdProyectoArchivo", cascadeDelete: true);
            AddForeignKey("dbo.ProyectoArchivo", "IdProyecto", "dbo.Proyecto", "IdProyecto", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProyectoArchivo", "IdProyecto", "dbo.Proyecto");
            DropForeignKey("dbo.ArchivoComentario", "IdProyectoArchivo", "dbo.ProyectoArchivo");
            DropIndex("dbo.ProyectoArchivo", new[] { "IdProyecto" });
            DropIndex("dbo.ArchivoComentario", new[] { "IdProyectoArchivo" });
            AlterColumn("dbo.ProyectoArchivo", "IdProyecto", c => c.Int());
            AlterColumn("dbo.ArchivoComentario", "IdProyectoArchivo", c => c.Int());
            RenameColumn(table: "dbo.ProyectoArchivo", name: "IdProyecto", newName: "Proyecto_IdProyecto");
            RenameColumn(table: "dbo.ArchivoComentario", name: "IdProyectoArchivo", newName: "ProyectoArchivo_IdProyectoArchivo");
            CreateIndex("dbo.ProyectoArchivo", "Proyecto_IdProyecto");
            CreateIndex("dbo.ArchivoComentario", "ProyectoArchivo_IdProyectoArchivo");
            AddForeignKey("dbo.ProyectoArchivo", "Proyecto_IdProyecto", "dbo.Proyecto", "IdProyecto");
            AddForeignKey("dbo.ArchivoComentario", "ProyectoArchivo_IdProyectoArchivo", "dbo.ProyectoArchivo", "IdProyectoArchivo");
        }
    }
}
