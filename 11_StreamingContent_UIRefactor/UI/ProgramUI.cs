using _07_RepositoryPattern_Repository;
using _08_StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_StreamingContent_UIRefactor.UI
{
    public class ProgramUI
    {
        private readonly StreamingRepository _repo = new StreamingRepository();
        private IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            SeedContent();
            Menu();
        }

        public void SeedContent()
        {
            _console.WriteLine("Seeding contents...");

            StreamingContent sc1 = new StreamingContent("Freaked", "Alex Winter and Keanu Reeves", MaturityRating.PG, 5, GenreType.Comedy);

            StreamingContent sc2 = new StreamingContent("Jackie Chan's First Strike", "Jackie Chan stops some terrorists", MaturityRating.PG13, 4.5, GenreType.Action);

            StreamingContent sc3 = new StreamingContent("Hawk Jones", "Buddy cop movie with a cast of all children", MaturityRating.PG, 5, GenreType.Comedy);

            _repo.AddContentToDirectory(sc1);
            _repo.AddContentToDirectory(sc2);
            _repo.AddContentToDirectory(sc3);
        }

        public void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();

                // \n = new line = CR + LF
                // CR = Carriage Return
                // LF = Line Feed
                _console.WriteLine("Menu:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Remove streaming content\n" +
                    "5. Exit");

                string userInput = _console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        // Show all content
                        DisplayAllContents();
                        break;
                    case "2":
                        // Find by title
                        GetContentByTitle();
                        break;
                    case "3":
                        // Add new content
                        AddNewContent();
                        break;
                    case "4":
                        // Remove content
                        RemoveContent();
                        break;
                    case "exit":
                    case "EXIT":
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a valid selection\n" +
                            "Press any key to continue...");
                        _console.ReadKey();
                        break;
                }
            }

            _console.Clear();
            _console.WriteLine("Goodbye!");
            Thread.Sleep(2000);

            // returns a ConsoleKeyInfo:
            // var key = _console.ReadKey();
            // returns a string:
            // _console.ReadLine();
        }

        public void DisplayAllContents()
        {
            _console.Clear();

            List<StreamingContent> contents = _repo.GetContents();

            foreach (StreamingContent content in contents)
            {
                DisplayContent(content);
            }

            ContinueMessage();
        }

        public void GetContentByTitle()
        {
            _console.Clear();
            _console.Write("Enter a title: ");
            string title = _console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);

            if (content == null)
            {
                _console.WriteLine("Content not found :(");
            }
            else
            {
                DisplayContent(content);
            }

            ContinueMessage();
        }

        public void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"{content.Title} ({content.MaturityRating}) - {content.Description}. {content.StarRating} {(content.StarRating == 1.0 ? "star" : "stars")}");
        }

        public void ContinueMessage()
        {
            _console.WriteLine("\nPress any key to continue...");
            _console.ReadKey();
        }




        private void AddNewContent()
        {
            _console.Clear();

            StreamingContent content = new StreamingContent();

            // Title
            bool isValidTitle = false;
            while (!isValidTitle)
            {
                _console.Write("Title: ");
                string title = _console.ReadLine();

                // content.Title = string.IsNullOrWhiteSpace(title) ? "Untitled" : title;
                if (string.IsNullOrWhiteSpace(title))
                {
                    _console.WriteLine("Please enter a valid title (press any key to continue)");
                    _console.ReadKey();
                }
                else
                {
                    content.Title = title;
                    isValidTitle = true;
                }
            }

            // Description
            _console.Write("Description: ");
            string description = _console.ReadLine();
            content.Description = string.IsNullOrWhiteSpace(description) ? "(No Description)" : description;

            // Star Rating
            _console.Write("Star Rating (0-5): ");
            double stars = double.Parse(_console.ReadLine());
            if (stars > 5)
            {
                content.StarRating = 5;
            } else if (stars < 0)
            {
                content.StarRating = 0;
            } else
            {
                content.StarRating = stars;
            }

            // Maturity
            _console.WriteLine("1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. NC-17\n" +
                "6. TV-MA\n" +
                "7. TV-G\n" +
                "8. TV-Y\n");
            _console.Write("Maturity rating (#): ");
            string maturityInput = _console.ReadLine();
            int maturityId = int.Parse(maturityInput);
            content.MaturityRating = (MaturityRating)maturityId;

            // content.MaturityRating = (MaturityRating)Int32.Parse(_console.ReadLine());

            // compile-time error gives you a red line, won't build or run
            // run-time error doesn't happen until the code builds and runs

            // Genre
            _console.WriteLine("1. SciFi\n" +
                "2. Comedy\n" +
                "3. Horror\n" +
                "4. Romantic Comedy\n" +
                "5. Documentary\n" +
                "6. Western\n" +
                "7. Action");
            _console.Write("Genre: ");
            string genreInput = _console.ReadLine();

            switch(genreInput)
            {
                case "scifi":
                case "SciFi":
                case "sci-fi":
                case "Sci-Fi":
                case "one":
                case "1":
                    content.GenreType = GenreType.SciFi;
                    break;
                case "2":
                case "comedy":
                    content.GenreType = GenreType.Comedy;
                    break;
                case "3":
                case "horror":
                    content.GenreType = GenreType.Horror;
                    break;
                case "4":
                case "rom com":
                case "romantic comedy":
                    content.GenreType = GenreType.RomCom;
                    break;
                case "5":
                    content.GenreType = GenreType.Documentary;
                    break;
                case "6":
                    content.GenreType = GenreType.Western;
                    break;
                case "7":
                    content.GenreType = GenreType.Action;
                    break;
                default:
                    content.GenreType = 0;
                    break;
            }

            _repo.AddContentToDirectory(content);
        }


        private void RemoveContent()
        {
            _console.Clear();
            _console.Write("Enter title of item to remove: ");

            string title = _console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);

            if (content == null)
            {
                _console.WriteLine("Content not found :(");
            }
            else
            {
                DisplayContent(content);
                _console.WriteLine("Are you sure you want to delete this? (y/n)");

                string answer = _console.ReadLine();
                // y Y yes Yes YES yEs YeS yES
                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    _repo.DeleteExistingContent(content);
                    _console.WriteLine("Content removed!");
                } else
                {
                    _console.WriteLine("Nevermind then...");
                }
            }

            ContinueMessage();
        }
    }
}
