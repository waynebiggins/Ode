using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OdeToFood.Models;
using System.Data.Entity;

namespace OdeToFood.Queries
{
    public static class Extension
    {
        public static List<Review> FindTheLatest(this List<Review> reviews, int num)
        {
            return reviews.OrderByDescending(o => o.Created)
                          .Take(num)
                          .ToList();
        }

        public static Review FindById(this List<Review> list, int id)
        {
            return list.SingleOrDefault(s => s.Id == id);
        }

        public static Review FindTheBest(this List<Review> list)
        {
            return list.OrderByDescending(o => o.Rating).FirstOrDefault();
        }
    }

}