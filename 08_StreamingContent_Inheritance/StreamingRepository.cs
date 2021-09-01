using _07_RepositoryPattern_Repository;
using _08_StreamingContent_Inheritance.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                // if (content is Show && ...
                if (content.GetType() == typeof(Show) && content.Title == title)
                {
                    return (Show) content;
                }
            }

            return null;

            // fancy way with Linq
            return (Show)_contentDirectory.FirstOrDefault(s => s is Show && s.Title == title);
        }

        public Movie GetMovieByTitle(string title)
        {
            return (Movie)_contentDirectory.FirstOrDefault(m => m is Movie && m.Title == title);
        }

        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                {
                    allShows.Add((Show) content);
                }
            }
            return allShows;
            // cast = convert a type to another compatible type
            return _contentDirectory.Where(s => s is Show).Cast<Show>().ToList();

            // yes
            // double x = 0.3;
            // float y = (float) x;

            // no
            // string a = (string) x;
        }

        public List<Movie> GetAllMovies()
        {
            return _contentDirectory.Where(s => s is Movie).Cast<Movie>().ToList();
        }

        // CHALLENGE(S):

        // Get Movies by Rating
        public List<Movie> GetMoviesByStarRating(double stars)
        {
            return GetAllMovies().Where(m => m.StarRating >= stars).ToList();
        }

        public List<Movie> GetMoviesByMaturityRating(MaturityRating rating)
        {
            return GetAllMovies().Where(m => m.MaturityRating <= rating).ToList();
        }

        // Get Shows by Rating
        public List<Show> GetShowsByStarRating(double stars)
        {
            return GetAllShows().Where(s => s.StarRating >= stars).ToList();
        }

        // Get Movies by Genre

        public List<Movie> GetMoviesByGenre(GenreType genre)
        {
            return GetAllMovies().Where(m => m.GenreType == genre).ToList();
        }

        // Get Shows by Genre
    }
}
