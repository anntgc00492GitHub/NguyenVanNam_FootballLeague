using System.Web;
using System.Web.Mvc;

namespace NguyenVanNam_FootballLeague.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
