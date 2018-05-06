using System.Web.Mvc;

namespace Mentorship.Grid.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return Json("Hello world!", JsonRequestBehavior.AllowGet);
        }
    }
}