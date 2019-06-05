using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.Models;

namespace TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.DataConexto
{
    public class DataContexto:DbContext
    {
        public DataContexto()
            :base("Conexao")
        {

        }

        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Autor> Autor { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}