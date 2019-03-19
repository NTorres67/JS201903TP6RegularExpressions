using System.Web;
using System.Web.Mvc;

namespace JS201903TP6RegularExpressions
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
