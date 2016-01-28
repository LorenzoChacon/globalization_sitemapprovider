using System.Globalization;
using System.Threading;
using System.Web.Mvc;


namespace SiteMapProviderGlobalizationDemo.App_Start
{
    public class CultureFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var values = filterContext.RouteData.Values;

            string culture = (string)values["lang"] ?? "en";

            CultureInfo cI = new CultureInfo(culture);

            Thread.CurrentThread.CurrentCulture = cI;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(cI.Name);
        }
    }
}