//Name: COMP2007 Enterprise Computing final project  - Summer 2016
//Author: Mo Zou &　Pui in Kwok & Yang Li
//Description: This assignment base on assginment 2, the MVC restaurant. Then add more security control and get motified website. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using finalProject.Models;

namespace finalProject.Controllers
{

    
    public class MenuController : Controller
    {
        RestaurantContext storeDB = new RestaurantContext();


        // GET: menu/
        public ActionResult Index()
        {
            List<Menu> menus = storeDB.Menus.ToList();

            return View(menus);
        }

        // GET: /Menu/Browse?menu=Appetizer

        public ActionResult Browse(string menu = "Appetizer")
        {
            // Retrieve Menu and its Associated items from database
            Menu menuModel = storeDB.Menus.Include("Items").Single(g => g.Name == menu);

            return View(menuModel);
        }

        // GET: /Menu/Details

        public ActionResult Details(int id = 1)
        {
            Item item = storeDB.Items.Find(id);

            return View(item);
        }
    }
}