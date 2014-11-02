using System.Web.Mvc;

namespace MaddiSmith.UI.Controllers
{
    public class SharedController : Controller
    {
       public ActionResult Index()
        {
            return View();
        }

        public ActionResult MessageBox()
        {
            return PartialView();
        }

    }
}
