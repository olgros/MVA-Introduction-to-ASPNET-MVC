namespace MVCMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracionPrueba1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PersonaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personas");
        }
    }
}
