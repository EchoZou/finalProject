//Name: COMP2007 Enterprise Computing final project  - Summer 2016
//Author: Mo Zou &　Pui in Kwok & Yang Li
//Description: This assignment base on assginment 2, the MVC restaurant. Then add more security control and get motified website. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace finalProject.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<RestaurantContext>
    {
        protected override void Seed(RestaurantContext context)
        {
            //menu schema
            var menus = new List<Menu>
            {
                new Menu { Name = "Appetizer" },
                new Menu { Name = "Main Course" },
                new Menu { Name = "Desserts" },
                new Menu { Name = "Beverages" }
            };

            //item schema
            new List<Item>
            {

                new Item { Title = "Seaweed Salad", Menu = menus.Single(g => g.Name == "Appetizer"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/seaweed_salad.jpg" },
                new Item { Title = "Tofu soup", Menu = menus.Single(g => g.Name == "Appetizer"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/tofu_soup.jpg" },
                new Item { Title = "New York Steak", Menu = menus.Single(g => g.Name == "Appetizer"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/NewYork_Steak.jpg" },
                new Item { Title = "Noodles", Menu = menus.Single(g => g.Name == "Main Course"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/noodles.jpg" },
                new Item { Title = "Fried Rice", Menu = menus.Single(g => g.Name == "Main Course"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/fried_rice.jpg" },
                new Item { Title = "Mango ice cream", Menu = menus.Single(g => g.Name == "Desserts"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M,  URL = "/Content/Images/mango_ice_cream.jpg" },
                new Item { Title = "Matcha ice cream", Menu = menus.Single(g => g.Name == "Desserts"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M,  URL = "/Content/Images/matcha_ice_cream.jpg" },
                new Item { Title = "Red bean ice cream", Menu = menus.Single(g => g.Name == "Desserts"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/red_bean_ice_cream.jpg" },
                new Item { Title = "Pop", Menu = menus.Single(g => g.Name == "Beverages"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/pop.jpg" },
                new Item { Title = "Coffee", Menu = menus.Single(g => g.Name == "Beverages"), ShortDescription="short description", DetailedDescription="this is detailed description", Price = 8.99M, URL = "/Content/Images/coffee.jpg" },

            }.ForEach(a => context.Items.Add(a));
        }
    }
}