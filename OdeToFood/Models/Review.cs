﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}