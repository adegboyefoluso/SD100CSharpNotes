using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _14_RestaurantRater.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(0,10)]
        public double FoodScore { get; set; }

        [Required]
        [Range(0, 10)]
        public double AtmosphereScore { get; set; }

        [Required]
        [Range(0,10)]
        public double CleanlinessScore { get; set; }


        public double AverageScore
        {
            get
            {
                return (FoodScore + AtmosphereScore + CleanlinessScore) / 3;
            }
        }

        // Foreign Key annotation, it looks at the virtual object and uses the RestaurantId to figure out which one.

        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}