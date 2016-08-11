//Name: COMP2007 Enterprise Computing final project  - Summer 2016
//Author: Mo Zou &　Pui in Kwok & Yang Li
//Description: This assignment base on assginment 2, the MVC restaurant. Then add more security control and get motified website. 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace finalProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
