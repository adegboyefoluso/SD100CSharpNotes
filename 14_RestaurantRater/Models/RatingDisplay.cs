using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _14_RestaurantRater.Models
{
    public class RatingDisplay
    {
        public int Id { get; set; }
        public double FoodScore { get; set; }
        public double AtmosphereScore { get; set; }
        public double CleanlinessScore { get; set; }
        public double AverageScore
        {
            get
            {
                return (FoodScore + AtmosphereScore + CleanlinessScore) / 3;
            }
        }
        public RestaurantListItem Restaurant { get; set; }
    }
}