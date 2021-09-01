using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContent
    {
        // backing field
        private string _title;
        public string Title {
            get { return _title; }
            set
            {
                _title = value.ToUpper();
                // string[] words = value.Split(' ');
            }
        }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly { get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TVG:
                    case MaturityRating.TVY:
                        return true;
                    default:
                        return false;
                }
            }
        }
        public GenreType GenreType { get; set; }

        public StreamingContent() { }

        public StreamingContent(string title, MaturityRating rating)
        {
            Title = title;
            MaturityRating = rating;
        }

        public StreamingContent(string title, string description, MaturityRating maturityRating, double stars, GenreType genre)
        {
            /*
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception("Content needs a title!");
            }
            */
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = stars;
            // IsFamilyFriendly = familyFriendly;
            GenreType = genre;
        }

        // Refactor the class so that IsFamilyFriendly always gives the right answer

    }
}

// public enum FamilyFriendlyRatings { G, PG, TVG }
public enum MaturityRating { G=1, PG, PG13, R, NC17, TVMA, TVG, TVY }
public enum GenreType { SciFi=1, Comedy, Horror, RomCom, Documentary, Western, Action }