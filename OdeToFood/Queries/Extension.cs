using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OdeToFood.Models;

namespace OdeToFood.Queries
{
    public static class Extension
    {
        public static List<RestaurantReview> FindTheLatest(this List<RestaurantReview> reviews, int num)
        {
            return reviews.OrderByDescending(o => o.Created)
                          .Take(num)
                          .ToList();
        }

        public static RestaurantReview FindById(this List<RestaurantReview> list, int id)
        {
            return list.SingleOrDefault(s => s.Id == id);
        }

        public static RestaurantReview FindTheBest(this List<RestaurantReview> list)
        {
            return list.OrderByDescending(o => o.Rating).FirstOrDefault();
        }
    }

}