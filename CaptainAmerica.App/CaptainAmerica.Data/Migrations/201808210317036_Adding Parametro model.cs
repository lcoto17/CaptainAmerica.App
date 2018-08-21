namespace CaptainAmerica.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingParametromodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parametro",
                c => new
                    {
                        IdParametro = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Valor = c.String(),
                    })
                .PrimaryKey(t => t.IdParametro);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Parametro");
        }
    }
}
