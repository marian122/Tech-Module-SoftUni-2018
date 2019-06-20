using System;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace Articles2 
{
    class Program
    {
        static void Main(string[] args)
        {

            int commandCount = int.Parse(Console.ReadLine());

            var articleKeeper = new List<Article>();

            for (int i = 0; i < commandCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                
                string title = tokens[0];
                string content = tokens[1];
                string author = tokens[2];

                var currArticle = new Article(title, content, author);
                articleKeeper.Add(currArticle);

            }
                string command = Console.ReadLine();

                PrintResult(articleKeeper, command);
            

        }
        private static void PrintResult(List<Article> articleKeeper, string command)
        {

            if (command == "title")
            {

                foreach (var current in articleKeeper.OrderBy(x => x.Title))
                {
                    current.OverrideToString();
                }
                
            }
            if (command == "content")
            {

                foreach (var current in articleKeeper.OrderBy(x => x.Content))
                {
                    current.OverrideToString();
                }

            }
            if (command == "author")
            {

                foreach (var current in articleKeeper.OrderBy(x => x.Author))
                {
                    current.OverrideToString();
                }

            }
        }
        
        class Article
        {
            public string Title { get; set; }

            public string Content { get; set; }

            public string Author { get; set; }
            
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }



            public void OverrideToString()
            {
                Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
            }
        }
    }
}
