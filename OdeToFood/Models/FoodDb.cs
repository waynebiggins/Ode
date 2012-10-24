using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class FoodDb
    {
        private static List<RestaurantReview> _reviews { get; set; }
        public List<RestaurantReview> Reviews
        {
            get
            {
                return _reviews;
            }
        }

        static FoodDb()
        {
            _reviews = new List<RestaurantReview>();
            _reviews.Add(new RestaurantReview
            {
                Id= 1,
                Name = "Jim Baxters",
                Comment = "This is poor",
                Rating = 5,
                Created = DateTime.Now,
            }
                );
            _reviews.Add(new RestaurantReview
            {
                Id=2,
                Name = "Jim McCocks",
                Comment = "Wonderful",
                Rating = 8,
                Created = DateTime.Now,
            }
               );
            _reviews.Add(new RestaurantReview
            {
                Id=3,
                Name = "Robbos Ginger Palace",
                Comment = "Best Meal Ever",
                Rating = 10,
                Created = DateTime.Now,
            }
               );
        }
    }
}