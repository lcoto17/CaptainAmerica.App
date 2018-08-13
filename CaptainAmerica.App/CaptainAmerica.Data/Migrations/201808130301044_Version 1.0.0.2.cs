namespace CaptainAmerica.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version1002 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProyectoMiembro", "Proyecto_IdProyecto", "dbo.Proyecto");
            DropForeignKey("dbo.ProyectoMiembro", "Usuario_IdUsuario", "dbo.Usuario");
            DropIndex("dbo.ProyectoMiembro", new[] { "Proyecto_IdProyecto" });
            DropIndex("dbo.ProyectoMiembro", new[] { "Usuario_IdUsuario" });
            RenameColumn(table: "dbo.ProyectoMiembro", name: "Proyecto_IdProyecto", newName: "IdProyecto");
            RenameColumn(table: "dbo.ProyectoMiembro", name: "Usuario_IdUsuario", newName: "IdUsuario");
            AlterColumn("dbo.ProyectoMiembro", "IdProyecto", c => c.Int(nullable: false));
            AlterColumn("dbo.ProyectoMiembro", "IdUsuario", c => c.Int(nullable: false));
            CreateIndex("dbo.ProyectoMiembro", "IdProyecto");
            CreateIndex("dbo.ProyectoMiembro", "IdUsuario");
            AddForeignKey("dbo.ProyectoMiembro", "IdProyecto", "dbo.Proyecto", "IdProyecto", cascadeDelete: true);
            AddForeignKey("dbo.ProyectoMiembro", "IdUsuario", "dbo.Usuario", "IdUsuario", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProyectoMiembro", "IdUsuario", "dbo.Usuario");
            DropForeignKey("dbo.ProyectoMiembro", "IdProyecto", "dbo.Proyecto");
            DropIndex("dbo.ProyectoMiembro", new[] { "IdUsuario" });
            DropIndex("dbo.ProyectoMiembro", new[] { "IdProyecto" });
            AlterColumn("dbo.ProyectoMiembro", "IdUsuario", c => c.Int());
            AlterColumn("dbo.ProyectoMiembro", "IdProyecto", c => c.Int());
            RenameColumn(table: "dbo.ProyectoMiembro", name: "IdUsuario", newName: "Usuario_IdUsuario");
            RenameColumn(table: "dbo.ProyectoMiembro", name: "IdProyecto", newName: "Proyecto_IdProyecto");
            CreateIndex("dbo.ProyectoMiembro", "Usuario_IdUsuario");
            CreateIndex("dbo.ProyectoMiembro", "Proyecto_IdProyecto");
            AddForeignKey("dbo.ProyectoMiembro", "Usuario_IdUsuario", "dbo.Usuario", "IdUsuario");
            AddForeignKey("dbo.ProyectoMiembro", "Proyecto_IdProyecto", "dbo.Proyecto", "IdProyecto");
        }
    }
}
