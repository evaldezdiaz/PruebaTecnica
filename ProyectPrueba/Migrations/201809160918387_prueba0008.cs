namespace ProyectPrueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba0008 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Persona", "Sexo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Persona", "Sexo", c => c.Int(nullable: false));
        }
    }
}
