using SiteMapProviderGlobalizationDemo.App_Start;
using System.Web;
using System.Web.Mvc;

namespace SiteMapProviderGlobalizationDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CultureFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
