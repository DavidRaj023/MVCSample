using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCSample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Custom Route
            //{ year = @"2015|2016", month = @"\d{2}"}
            /*routes.MapRoute(
                "MovieByReleaseDate",
                "movie/released/{year}/{month}",
                new { controller = "Movie", action = "ByReleaseDate" },
                new { year = @"\d{4}", month = @"\d{2}"}
                );*/

            //Attribute Route
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
