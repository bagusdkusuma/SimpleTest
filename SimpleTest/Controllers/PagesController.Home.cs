using System.Web.Mvc;

namespace SimpleTest.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }
    }
}