using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;
using OdeToFood.Queries;
using System.Data;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        OdeToFoodDB _db = new OdeToFoodDB();
       

        public ActionResult Index()
        {
            var model = _db.Reviews;

            return View(model);
        }

       

        public ActionResult Details(int id)
        {
            return View();
        }

        

        public ActionResult Create()
        {
            return View(new Review());
        } 

       

        [HttpPost]
        public ActionResult Create(int restaurantID, Review newReview)
        {
            try
            {
               
                var restaurant = _db.Restaurants.Single(r => r.ID == restaurantID);
                restaurant.Reviews.Add(newReview);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        
 
        public ActionResult Edit(int id)
        {
            var review = _db.Reviews.Find(id);
            return View(review);
        }

        

        [HttpPost]
        public ActionResult Edit(Review review)
        {

            if (ModelState.IsValid)
            {

                _db.Entry(review).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            review = _db.Reviews.Find(review.Id);
            return View(review);

        }

      

      
 
        public ActionResult Delete(int id)
        {
            return View();
        }

       

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
               
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
