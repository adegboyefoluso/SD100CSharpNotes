using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class RepositoryTests
    {
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();

            _content = new StreamingContent("Twisted Pair", "Neil Breen's latest masterpiece", MaturityRating.R, 5.0, GenreType.SciFi);

            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void AddContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContentRepository repo = new StreamingContentRepository();
            StreamingContent content = new StreamingContent();
            content.Title = "I Am Here.... NOW";
            // Act
            bool addResult = repo.AddContentToDirectory(content);
            // Assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            StreamingContentRepository repo = new StreamingContentRepository();
            StreamingContent content = new StreamingContent();
            content.Title = "Pass Thru";

            repo.AddContentToDirectory(content);

            List<StreamingContent> contents = repo.GetContents();

            bool directoryHasContent = contents.Contains(content);

            Assert.IsTrue(directoryHasContent);
        }

        [TestMethod]
        public void GetContentByTitle_ShouldGetCorrectContent()
        {
            StreamingContent content = _repo.GetContentByTitle("TWISTED PAIR");
            Assert.AreEqual(_content, content);
        }

        [TestMethod]
        public void GetFamilyFriendlyContent_ShouldAllBeFamilyFriendly()
        {
            StreamingContent safeItem = new StreamingContent();
            StreamingContent unsafeItem = new StreamingContent();

            safeItem.MaturityRating = MaturityRating.G;
            unsafeItem.MaturityRating = MaturityRating.R;

            _repo.AddContentToDirectory(safeItem);
            _repo.AddContentToDirectory(unsafeItem);

            List<StreamingContent> familyFriendlyContents = _repo.GetFamilyFriendlyContent();

            // bool hasUnsafeContent = false
            // Loop through list
            //    if not family friendly
            //        hasUnsafeContent = true
            //        break
            // Assert hasUnsafeContent is false

            int unsafeItems = familyFriendlyContents.Where(s => !s.IsFamilyFriendly).ToList().Count;
            
            Assert.AreEqual(0, unsafeItems);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldUpdate()
        {
            StreamingContent newData = new StreamingContent("Twisted Pair", "Two identical twin brothers become hybrid, super power, artificial intelligence entities...", MaturityRating.R, 6.0, GenreType.Action);

            _repo.UpdateExistingContent("TWISTED PAIR", newData);

            var expected = GenreType.Action;
            var actual = _content.GenreType;
            // var actual = _repo.GetContentByTitle("TWISTED PAIR").GenreType;

            Assert.AreEqual(expected, actual);
        }
    }
}
