using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Cors;
using System.Web.Http;
namespace API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //config.EnableCors();
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
            // Web API routes
            config.MapHttpAttributeRoutes();
   
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "getlottezybydate",
                routeTemplate: "lottezy/{id}"
            );
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
