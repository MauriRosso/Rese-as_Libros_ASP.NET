namespace Libreria_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agrear_Campos_Adicionales : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "Alias", c => c.String(maxLength: 256));
            AddColumn("dbo.AspNetUsers", "FechaRegistro", c => c.DateTime(nullable: false));

        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Activo");
            DropColumn("dbo.AspNetUsers", "Alias");
            DropColumn("dbo.AspNetUsers", "FechaRegistro");
        }
    }
}
