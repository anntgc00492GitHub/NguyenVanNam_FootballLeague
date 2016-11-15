using System.Web.Mvc;

namespace NguyenVanNam_FootballLeague.Web.Areas.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            return RedirectToAction("LogOff2", "Account", new { area = "" });
        }
    }
}