using _03_Repository_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Repository_Pattern_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _streamingRepo = new StreamingContentRepository();

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add new content\n" +
                    "2. See all content\n" +
                    "3. Get content by title\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Add Content
                        CreateAndAddContentToList();
                        break;
                    case "2":
                        // See All Content
                        break;
                    case "3":
                        // Get Content by Title
                        break;
                    case "4":
                        // Exit
                        running = false;
                        break;
                }
            }
        }

        private void CreateAndAddContentToList()
        {
            Console.WriteLine("What is the title of the streaming content?");
            string title = Console.ReadLine();

            Console.WriteLine("What is the star rating?");
            string starsAsString = Console.ReadLine();
            int starRating = int.Parse(starsAsString);

            Console.WriteLine("What is the genre?\n" +
                "1. Horror\n" +
                "2. Comedy\n" +
                "3. Drama\n" +
                "4. SciFi\n" +
                "5. Cartoon\n" +
                "6. Kids\n" +
                "7. Bromance\n" +
                "8. RomCom\n" +
                "9. Western\n" +
                "10. Thriller");

            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);
            GenreType genre = (GenreType)input; // -- This is casting

            Console.WriteLine("Is this mature? (Y/N)");
            string isMatureAsString = Console.ReadLine().ToLower();
            bool isMature;

            switch (isMatureAsString)
            {
                case "y":
                case "yes":
                    isMature = true;
                    break;
                case "n":
                case "no":
                default:
                    isMature = false;
                    break;
            }

            Console.WriteLine("What is the rating?");
            string rating = Console.ReadLine();

            Console.WriteLine("What is the run time in minutes?");
            double runTime = double.Parse(Console.ReadLine());

            StreamingContent newContent = new StreamingContent(title, starRating, genre, isMature, rating, runTime);
            _streamingRepo.AddToList(newContent);
        }
    }
}
