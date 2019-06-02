using System.Web.Mvc;
using System.Linq;
using TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.DataConexto;
using System.Net;
using TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.Models;

namespace TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.Controllers
{
    
    public class TutorialPartialViewController : Controller
    {
        // GET: TutorialPartialView
        DataContexto db = new DataContexto();    
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ListarCursos()
        {
            var result = db.Cursos.ToList();
            return PartialView(result);
        }
        public ActionResult Detalhes(int ? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cursos cursos = db.Cursos.Find(id);
            if (cursos == null)
            {
                return HttpNotFound();
            }
            return View(cursos);

        }
      
    }
}