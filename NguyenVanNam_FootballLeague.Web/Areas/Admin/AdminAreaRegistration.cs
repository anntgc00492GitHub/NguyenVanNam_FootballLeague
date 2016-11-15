using System.Web.Mvc;

namespace NguyenVanNam_FootballLeague.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "NguyenVanNam_FootballLeague.Web.Areas.Admin.Controllers" }
            );
        }
    }
}