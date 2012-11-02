using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;
using OdeToFood.Queries;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        //FoodDb _db = new FoodDb();
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            //var model = _db.Reviews.FindTheBest();
            //var model = new Review();
            //model.Name = "Jim Baxter";
            //model.Rating = 5;
            //model.Body = "This place sucks";
            return View();
        }
         
        public ActionResult About()
        {
            return View();
        }
    }
}
