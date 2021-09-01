using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _14_RestaurantRater.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }

        public virtual List<Rating> Ratings { get; set; } = new List<Rating>();

        public double AverageRating
        {
            get
            {
                double totalAverageRating = 0;

                foreach(var rating in Ratings)
                {
                    totalAverageRating += rating.AverageScore;
                }

                return (Ratings.Count > 0) ? totalAverageRating / Ratings.Count : 0;
            }
        }

        public double AverageFoodScore
        {
            get
            {
                double averageFoodScore = 0;

                foreach (var rating in Ratings)
                {
                    averageFoodScore += rating.FoodScore;
                }

                return (Ratings.Count > 0) ? averageFoodScore / Ratings.Count : 0;
            }
        }

        public double AverageAtmosphereScore
        {
            get
            {
                double averageAtmoshpereScore = 0;

                foreach (var rating in Ratings)
                {
                    averageAtmoshpereScore += rating.AtmosphereScore;
                }

                return (Ratings.Count > 0) ? averageAtmoshpereScore / Ratings.Count : 0;
            }
        }

        public double AverageCleanlinessScore
        {
            get
            {
                double averageCleanlinessScore = 0;

                foreach (var rating in Ratings)
                {
                    averageCleanlinessScore += rating.CleanlinessScore;
                }

                return (Ratings.Count > 0) ? averageCleanlinessScore / Ratings.Count : 0;
            }
        }
    }
}