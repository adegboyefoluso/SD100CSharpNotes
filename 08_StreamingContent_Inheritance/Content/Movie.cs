using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance.Content
{
    public class Movie : StreamingContent
    {
        public double RunTime { get; set; }

        public Movie() { }

        public Movie(
            string title,
            string description,
            MaturityRating rating,
            double stars,
            GenreType genre,
            double runTime
            ) : base(
                title, 
                description,
                rating,
                stars,
                genre
                )
        {
            RunTime = runTime;
        }
    }
}