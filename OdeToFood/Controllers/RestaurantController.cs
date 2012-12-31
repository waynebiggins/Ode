using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;
using System.Data;

namespace OdeToFood.Controllers
{
    public class RestaurantController : Controller
    {
       
        OdeToFoodDB _db = new OdeToFoodDB();

        public ActionResult Index(string state)
        {
           
            var model =
                _db.Restaurants
                .OrderBy(r => r.Name);
                                  
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

        public ActionResult Details(int id)
        {
            var model = _db.Restaurants.Single(r => r.ID == id);
                return View(model);
        }

        public ActionResult Edit(int id)
        {
            var restaurant = _db.Restaurants.Find(id);

            return View(restaurant);
        }

        [HttpPost]
        public ActionResult Edit(Restaurant restaurant)
        {

            if (ModelState.IsValid)
            {

                _db.Entry(restaurant).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Details", new { id = restaurant.ID });

            }
            restaurant = _db.Restaurants.Find(restaurant.ID);
            return View(restaurant);

        }
    }
}
