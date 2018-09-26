using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RESTService
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // //parts/1/docs - get all documents for a part
            // routes.MapRoute(
            //     name: "DocumentsForPart",
            //     url: "{controller}/{id}/{action}",
            //     defaults: new
            //     {
            //         controller = "RentalProperties",
            //         action = "GetDocs",
            //         id = UrlParameter.Optional
            //     }
            // );

            // //OK
            // //parts/alldocs/1 - get all docs for a part with OBID=1
            // routes.MapRoute(
            //    name: "PartWithLinks",
            //    url: "api/{controller}/{action}/{id}",
            //    defaults: new
            //    {
            //        controller = "Parts",
            //        action = "AllDocs",
            //        id = UrlParameter.Optional
            //    }
            //);

            // //parts/1234xyz - get a part upon its OBID
            // routes.MapRoute(
            //     name: "PartsUponId",
            //     url: "parts/{id}",
            //     defaults: new
            //     {
            //         controller = "Parts",
            //         action = "Part",
            //     }
            // );

            // //parts/0770.6491.01 - get parts upon a part number
            // routes.MapRoute(
            //     name: "PartsUponPartNumber",
            //     url: "parts/{partNumber}",
            //     defaults: new
            //     {
            //         controller = "Parts",
            //         action = "Part",
            //     }
            // );

            // //parts - all parts
            // routes.MapRoute(
            //     name: "Parts",
            //     url: "allParts",
            //     defaults: new
            //     {
            //         controller = "Parts",
            //         action = "All",
            //         id = UrlParameter.Optional
            //     }
            // );




            //default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
