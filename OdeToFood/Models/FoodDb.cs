using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class FoodDb
    {
        private static List<Review> _reviews { get; set; }
        public List<Review> Reviews
        {
            get
            {
                return _reviews;
            }
        }

        static FoodDb()
        {
            _reviews = new List<Review>();
            _reviews.Add(new Review
            {
                Id = 1,
                Body = "This is poor",
                Rating = 5,
                Created = DateTime.Now,
                Restaurant = new Restaurant
                {
                    Name = "Jimbaxters"
                }

            }
                );
            _reviews.Add(new Review
            {
                Id=2,              
                Body = "Wonderful",
                Rating = 8,
                Created = DateTime.Now,
                Restaurant = new Restaurant
                {
                    Name = "GingerMarks"
                }
            }
               );
            _reviews.Add(new Review
            {
                Id=3,           
                Body = "Best Meal Ever",
                Rating = 10,
                Created = DateTime.Now,
                Restaurant = new Restaurant
                {
                    Name = "Sachas Sex Emporium"
                }
            }
               );
        }
    }
}