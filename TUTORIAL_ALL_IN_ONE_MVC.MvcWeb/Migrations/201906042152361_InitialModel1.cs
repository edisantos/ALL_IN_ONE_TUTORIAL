namespace TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autor",
                c => new
                    {
                        AutorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.AutorId);
            
            AddColumn("dbo.Cursos", "Autor_AutorId", c => c.Int());
            CreateIndex("dbo.Cursos", "Autor_AutorId");
            AddForeignKey("dbo.Cursos", "Autor_AutorId", "dbo.Autor", "AutorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cursos", "Autor_AutorId", "dbo.Autor");
            DropIndex("dbo.Cursos", new[] { "Autor_AutorId" });
            DropColumn("dbo.Cursos", "Autor_AutorId");
            DropTable("dbo.Autor");
        }
    }
}
