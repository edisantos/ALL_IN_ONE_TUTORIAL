namespace TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Cursos", new[] { "Autor_AutorId" });
            RenameColumn(table: "dbo.Cursos", name: "Autor_AutorId", newName: "AutorId");
            AlterColumn("dbo.Cursos", "AutorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cursos", "AutorId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cursos", new[] { "AutorId" });
            AlterColumn("dbo.Cursos", "AutorId", c => c.Int());
            RenameColumn(table: "dbo.Cursos", name: "AutorId", newName: "Autor_AutorId");
            CreateIndex("dbo.Cursos", "Autor_AutorId");
        }
    }
}
