namespace CaptainAmerica.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version1001 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuario", "Rol_IdRol", "dbo.Rol");
            DropIndex("dbo.Usuario", new[] { "Rol_IdRol" });
            RenameColumn(table: "dbo.Usuario", name: "Rol_IdRol", newName: "IdRol");
            AlterColumn("dbo.Usuario", "IdRol", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuario", "IdRol");
            AddForeignKey("dbo.Usuario", "IdRol", "dbo.Rol", "IdRol", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "IdRol", "dbo.Rol");
            DropIndex("dbo.Usuario", new[] { "IdRol" });
            AlterColumn("dbo.Usuario", "IdRol", c => c.Int());
            RenameColumn(table: "dbo.Usuario", name: "IdRol", newName: "Rol_IdRol");
            CreateIndex("dbo.Usuario", "Rol_IdRol");
            AddForeignKey("dbo.Usuario", "Rol_IdRol", "dbo.Rol", "IdRol");
        }
    }
}
