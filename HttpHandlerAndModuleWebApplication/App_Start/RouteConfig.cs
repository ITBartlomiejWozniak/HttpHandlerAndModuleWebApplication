using System.Web.Mvc;
using System.Web.Routing;

namespace HttpHandlerAndModuleWebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{assets}", new { assets = @".*\.(pdf|doc)(/.)?" });

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}"
            );
        }
    }
}
