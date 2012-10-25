using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
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
