using System.Collections.Generic;

namespace TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
        public ICollection<Cursos> Cursos { get; set; }
    }
}