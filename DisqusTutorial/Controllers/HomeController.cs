using System.Web.Mvc;

namespace DisqusTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult DisqusDefault()
        {
            return View();
        }

        public ActionResult DisqusAjax()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
