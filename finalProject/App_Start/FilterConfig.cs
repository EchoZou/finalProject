//Name: COMP2007 Enterprise Computing final project  - Summer 2016
//Author: Mo Zou &　Pui in Kwok & Yang Li
//Description: This assignment base on assginment 2, the MVC restaurant. Then add more security control and get motified website. 



using System.Web;
using System.Web.Mvc;

namespace finalProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {

            //filters.Add(new AuthorizeAttribute());
            filters.Add(new HandleErrorAttribute());


        }
    }
}
