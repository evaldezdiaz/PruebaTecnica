namespace ProyectPrueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba0005 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Persona", "Sexo_ID", "dbo.Sexo");
            DropIndex("dbo.Persona", new[] { "Sexo_ID" });
            AddColumn("dbo.Persona", "Sexo", c => c.Int(nullable: false));
            DropColumn("dbo.Persona", "IDSexo");
            DropColumn("dbo.Persona", "Sexo_ID");
            DropTable("dbo.Sexo");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Sexo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        sexo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Persona", "Sexo_ID", c => c.Int());
            AddColumn("dbo.Persona", "IDSexo", c => c.Int(nullable: false));
            DropColumn("dbo.Persona", "Sexo");
            CreateIndex("dbo.Persona", "Sexo_ID");
            AddForeignKey("dbo.Persona", "Sexo_ID", "dbo.Sexo", "ID");
        }
    }
}
