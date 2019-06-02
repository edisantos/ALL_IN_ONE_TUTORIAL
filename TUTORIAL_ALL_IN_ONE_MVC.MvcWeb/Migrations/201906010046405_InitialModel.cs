namespace TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursos",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        DataRegistro = c.DateTime(nullable: false),
                        Curso = c.String(nullable: false, maxLength: 50, unicode: false),
                        valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CursoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cursos");
        }
    }
}
