using System.Web;
using System.Web.Mvc;

namespace TUTORIAL_ALL_IN_ONE_MVC.MvcWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
