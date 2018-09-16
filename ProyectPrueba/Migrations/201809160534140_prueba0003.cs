namespace ProyectPrueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba0003 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IDSexo = c.Int(nullable: false),
                        Edad = c.Int(nullable: false),
                        Sexo_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sexo", t => t.Sexo_ID)
                .Index(t => t.Sexo_ID);
            
            CreateTable(
                "dbo.Sexo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        sexo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Persona", "Sexo_ID", "dbo.Sexo");
            DropIndex("dbo.Persona", new[] { "Sexo_ID" });
            DropTable("dbo.Sexo");
            DropTable("dbo.Persona");
        }
    }
}
