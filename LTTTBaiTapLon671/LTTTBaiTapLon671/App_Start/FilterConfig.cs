using System.Web;
using System.Web.Mvc;

namespace LTTTBaiTapLon671
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
