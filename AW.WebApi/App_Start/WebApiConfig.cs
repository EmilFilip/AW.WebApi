using AW.WebApi.Helpers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AW.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            config.Filters.Add(new CustomAuthorizeAttribute());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "2",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { action = "Get" }

            );

            config.Routes.MapHttpRoute(
                name: "1",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: null
            );
        }
    }
}
