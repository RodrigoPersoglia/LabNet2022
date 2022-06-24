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
    }
}
