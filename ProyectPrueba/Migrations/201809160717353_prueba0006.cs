namespace ProyectPrueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba0006 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Persona", "Nombre", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Persona", "Nombre", c => c.String());
        }
    }
}
