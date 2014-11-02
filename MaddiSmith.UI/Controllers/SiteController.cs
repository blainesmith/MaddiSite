using System.Web.Mvc;

namespace MaddiSmith.UI.Controllers
{
    public class SiteController : Controller
    {
        public ActionResult Home()
        {
            return PartialView();
        }
    }
}
