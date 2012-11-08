using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class RestaurantController : Controller
    {
        //
        // GET: /Restaurant/
        OdeToFoodDB _db = new OdeToFoodDB();

        public ActionResult Index()
        {
            var model = _db.Restaurants;
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Restaurant newRestaurant)
        {
            try
            {
                using (_db)
                {
                    _db.Restaurants.Add(newRestaurant);
                    _db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
