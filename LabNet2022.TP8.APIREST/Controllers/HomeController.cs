using LabNet2022.TP7.Logic.Services;
using System;
using System.Web.Mvc;

namespace LabNet2022.TP8.APIREST.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        public ActionResult Provincias()
        {
            try
            {
                var _service = new ServiceProvincias();
                var model = _service.GetProvincias();
                return View(model);
            }
            catch (Exception) { return RedirectToAction("Index"); }
        }

    }


}
