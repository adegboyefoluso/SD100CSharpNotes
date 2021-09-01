using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        // CRUD
        // Create ✓
        // Read ✓
        // Update ✓
        // Delete ✓

        // Repository pattern = a "database" or list + CRUD methods

        // Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = _contentDirectory.Count > startingCount;
            return wasAdded;

            // return _contentDirectory.Count > startingCount;
        }
        // Read
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            // Pseudocode:
            // Loop through the list
            //    If content item has correct title
            //        return the item
            // return null or throw error

            foreach(StreamingContent item in _contentDirectory)
            {
                if (item.Title == title)
                {
                    return item;
                }
            }
            return null;
        }


        // Create a method (GetFamilyFriendlyContent) that returns only family-friendly content

        public List<StreamingContent> GetFamilyFriendlyContent()
        {
            // get all contents
            // make empty list
            // loop through contents
            //    if friendly
            //       add to list
            // return the list
            List<StreamingContent> content = GetContents();
            List<StreamingContent> familyFriendlyContents = new List<StreamingContent>();
            foreach (StreamingContent item in content)
            {
                if (item.IsFamilyFriendly)
                {
                    familyFriendlyContents.Add(item);
                }
            }
            return familyFriendlyContents;
            // Fancy version using LINQ:
            //                            lambda expression
            return GetContents().Where(s => s.IsFamilyFriendly).ToList();
        }




        // Create a method to return movies by genre (GetContentsByGenre)


        // public List<StreamingContent> GetContentsByGenre(GenreType genre) {

        // get the full contents
        // make empty list
        // loop through contents
        //    if content is genre
        //        add to list
        // return the list

        // return GetContents().Where(s => s.GenreType == genre).ToList();


        // Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.StarRating = newContent.StarRating;
                oldContent.GenreType = newContent.GenreType;

                return true;
            }

            return false;
        }

        // Delete
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
    }
}
