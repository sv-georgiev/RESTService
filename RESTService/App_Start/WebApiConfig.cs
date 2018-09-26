using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RESTService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "PutSapStatus",
                routeTemplate: "api/{controller}/{id}/SapStatus",
                defaults: new { id = RouteParameter.Optional }
            );

            ////Get all documents for a part with OBID={id}
            //config.Routes.MapHttpRoute(
            //    name: "Put",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "ActionApi",
            //    routeTemplate: "api/{controller}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //Get all documents for a part with OBID ={ id}
            config.Routes.MapHttpRoute(
                name: "DocsForPart",
                routeTemplate: "api/{controller}/{id}/docs",
                defaults: new { id = RouteParameter.Optional }
            );

            ////Get all documents for a part with OBID={id}
            //config.Routes.MapHttpRoute(
            //    name: "DocsForPartAlt",
            //    routeTemplate: "api/{controller}/{id}/{action}",
            //    defaults: new { id = RouteParameter.Optional }
            //);


        }
    }
}
