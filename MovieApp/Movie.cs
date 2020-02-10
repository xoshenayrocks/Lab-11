using System;
using System.Collections.Generic;

namespace MovieApp
{
    public class Movie
    {
        private string Title { get; set; }
        private string Category { get; set; }

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }


        public static void PrintMovieSelection(List<Movie> listOfMovies, string userInput)
        {
            
            foreach (Movie movie in listOfMovies)
            {
                if (userInput == "animated".ToLower() && movie.Category == "animated")
                { Console.WriteLine(movie.Title); }

                else if (userInput == "drama".ToLower() && movie.Category == "drama")
                {
                    Console.WriteLine(movie.Title);
                }
                else if (userInput == "horror".ToLower() && movie.Category == "horror")
                {
                    Console.WriteLine(movie.Title);
                }
                else if (userInput == "comedy" && movie.Category == "comedy")
                {
                    Console.WriteLine(movie.Title);
                }
               

            }

        }


    }
}
