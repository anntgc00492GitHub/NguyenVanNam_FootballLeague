using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenVanNam_FootballLeague.Web.CustomFilters;

namespace NguyenVanNam_FootballLeague.Web.Areas.Admin.Controllers
{
    [AuthLog(Roles = "Manager")]
    [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
    public class ManagerController : Controller
    {
        // GET: Admin/Manager
        public ActionResult Index()
        {
            return View();
        }
    }
}