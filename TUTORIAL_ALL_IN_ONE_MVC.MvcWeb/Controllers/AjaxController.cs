using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.DataConexto;
using TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.Models;

namespace TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        private DataContexto db = new DataContexto();
        public ActionResult Index()
        {

            return View(db.Cursos.ToList());
        }

        public ActionResult Registro()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registro(Cursos model)
        {
            if (!Request.IsAjaxRequest())
            {
                Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                return Content("Sorry, this method can't be called only from AJAX.");
            }
            try
            {
                if (ModelState.IsValid)
                {
                   
                    model.DataRegistro = DateTime.Now;
                    model.AutorId = 1;
                    db.Cursos.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    StringBuilder strB = new StringBuilder(500);
                    foreach (ModelState modelState in ModelState.Values)
                    {
                        foreach (ModelError error in modelState.Errors)
                        {
                            strB.Append(error.ErrorMessage + ".");
                        }
                    }
                    Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                    return Content(strB.ToString());
                }
            }
            catch (Exception ex)
            {


                Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                return Content("Sorry, an error occured." + ex.Message);
            }
           
            
            
        }
        [HttpGet]
        public JsonResult ListaCursos()
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;
            var result = db.Cursos.ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Contar()
        {
           
          
            var ResultCount = db.Cursos.Count();
            return Json(ResultCount, JsonRequestBehavior.AllowGet);
        }
    }
}