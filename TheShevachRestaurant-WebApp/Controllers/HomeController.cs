using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheShevachRestaurant_WebApp.Models;

namespace TheShevachRestaurant_WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET : Menu page
        public ActionResult Menu()
        {
            MenuModel menu = new MenuModel();

            return View(menu);
        }

        public ActionResult Meall(int id)
        {
            MenuModel menu = new MenuModel();

            Meal tempMeal = menu.Menus.Find(Meal => Meal.MealId == id);

            return View(tempMeal);
        }

        // GET : Contact page
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            MenuModel menu = new MenuModel();

            return View(menu);
        }

        
        
    }
}