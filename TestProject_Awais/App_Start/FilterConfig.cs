using System.Web;
using System.Web.Mvc;

namespace TestProject_Awais
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {

            filters.Add(new HandleErrorAttribute());
        }
    }
}
