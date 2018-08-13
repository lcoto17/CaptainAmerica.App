namespace CaptainAmerica.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version1000 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Proyecto", "Cliente_IdCliente", "dbo.Cliente");
            DropForeignKey("dbo.Proyecto", "ProyectoCategoria_IdCategoriaProyecto", "dbo.ProyectoCategoria");
            DropIndex("dbo.Proyecto", new[] { "Cliente_IdCliente" });
            DropIndex("dbo.Proyecto", new[] { "ProyectoCategoria_IdCategoriaProyecto" });
            RenameColumn(table: "dbo.Proyecto", name: "Cliente_IdCliente", newName: "IdCliente");
            RenameColumn(table: "dbo.Proyecto", name: "ProyectoCategoria_IdCategoriaProyecto", newName: "IdCategoriaProyecto");
            AlterColumn("dbo.Proyecto", "IdCliente", c => c.Int(nullable: false));
            AlterColumn("dbo.Proyecto", "IdCategoriaProyecto", c => c.Int(nullable: false));
            CreateIndex("dbo.Proyecto", "IdCliente");
            CreateIndex("dbo.Proyecto", "IdCategoriaProyecto");
            AddForeignKey("dbo.Proyecto", "IdCliente", "dbo.Cliente", "IdCliente", cascadeDelete: true);
            AddForeignKey("dbo.Proyecto", "IdCategoriaProyecto", "dbo.ProyectoCategoria", "IdCategoriaProyecto", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Proyecto", "IdCategoriaProyecto", "dbo.ProyectoCategoria");
            DropForeignKey("dbo.Proyecto", "IdCliente", "dbo.Cliente");
            DropIndex("dbo.Proyecto", new[] { "IdCategoriaProyecto" });
            DropIndex("dbo.Proyecto", new[] { "IdCliente" });
            AlterColumn("dbo.Proyecto", "IdCategoriaProyecto", c => c.Int());
            AlterColumn("dbo.Proyecto", "IdCliente", c => c.Int());
            RenameColumn(table: "dbo.Proyecto", name: "IdCategoriaProyecto", newName: "ProyectoCategoria_IdCategoriaProyecto");
            RenameColumn(table: "dbo.Proyecto", name: "IdCliente", newName: "Cliente_IdCliente");
            CreateIndex("dbo.Proyecto", "ProyectoCategoria_IdCategoriaProyecto");
            CreateIndex("dbo.Proyecto", "Cliente_IdCliente");
            AddForeignKey("dbo.Proyecto", "ProyectoCategoria_IdCategoriaProyecto", "dbo.ProyectoCategoria", "IdCategoriaProyecto");
            AddForeignKey("dbo.Proyecto", "Cliente_IdCliente", "dbo.Cliente", "IdCliente");
        }
    }
}
