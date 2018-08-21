namespace CaptainAmerica.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingArchivoComentariomodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArchivoComentario", "FechaCreacion", c => c.DateTime(nullable: false));
            AddColumn("dbo.ArchivoComentario", "IdUsuario", c => c.Int(nullable: false));
            CreateIndex("dbo.ArchivoComentario", "IdUsuario");
            AddForeignKey("dbo.ArchivoComentario", "IdUsuario", "dbo.Usuario", "IdUsuario", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArchivoComentario", "IdUsuario", "dbo.Usuario");
            DropIndex("dbo.ArchivoComentario", new[] { "IdUsuario" });
            DropColumn("dbo.ArchivoComentario", "IdUsuario");
            DropColumn("dbo.ArchivoComentario", "FechaCreacion");
        }
    }
}
