using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _14_RestaurantRater.Models
{
    public class RestaurantListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
    public class RestaurantItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double AverageRating { get; set; }
        public double AverageFoodScore { get; set; }
        public double AverageAtmosphereScore { get; set; }
        public double AverageCleanlinessScore { get; set; }
    }
}