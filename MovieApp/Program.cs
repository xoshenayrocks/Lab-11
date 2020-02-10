using System;
using System.Collections.Generic;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool willContinue = true;
            do
            {

           
            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie("Finding Nemo", "animated"));
            movies.Add(new Movie("Toy Story", "animated"));
            movies.Add(new Movie("Cars", "animated"));
            movies.Add(new Movie("Frozen", "animated"));
            movies.Add(new Movie("Moana", "animated"));
            movies.Add(new Movie("Shrek", "animated"));
            movies.Add(new Movie("Kung Fu Panda", "animated"));
            movies.Add(new Movie("Lion King", "animated"));
            movies.Add(new Movie("Mulan", "animated"));
            movies.Add(new Movie("Snow White", "animated"));

            movies.Add(new Movie("12 Angry Men", "drama"));
            movies.Add(new Movie("Moonlight", "drama"));
            movies.Add(new Movie("Godfather", "drama"));
            movies.Add(new Movie("The Shawshank Redemption", "drama"));
            movies.Add(new Movie("Titanic", "drama"));
            movies.Add(new Movie("Pulp Fiction", "drama"));
            movies.Add(new Movie("Dark Knight", "drama"));
            movies.Add(new Movie("Gladiator", "drama"));
            movies.Add(new Movie("Fight Club", "drama"));
            movies.Add(new Movie("The Pianist", "drama"));

            movies.Add(new Movie("It", "horror"));
            movies.Add(new Movie("The Shining", "horror"));
            movies.Add(new Movie("Scream", "horror"));
            movies.Add(new Movie("I Know What You Did Last Summer", "horror"));
            movies.Add(new Movie("Nightmare on Elm St", "horror"));
            movies.Add(new Movie("American Psycho", "horror"));
            movies.Add(new Movie("Friday the 13th", "horror"));
            movies.Add(new Movie("Saw", "horror"));
            movies.Add(new Movie("Amityville Horror", "horror"));
            movies.Add(new Movie("Carrie", "horror"));

            movies.Add(new Movie("All About The Benjamins", "comedy"));
            movies.Add(new Movie("The Hangover", "comedy"));
            movies.Add(new Movie("Girls Trip", "comedy"));
            movies.Add(new Movie("Bridesmaids", "comedy"));
            movies.Add(new Movie("Superbad", "comedy"));
            movies.Add(new Movie("Friday", "comedy"));
            movies.Add(new Movie("Daddy Daycare", "comedy"));
            movies.Add(new Movie("The Breakup", "comedy"));
            movies.Add(new Movie("Wedding Crashers", "comedy"));
            movies.Add(new Movie("American Pie", "comedy"));


            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine("There are 100 movies in this list.");
            Console.WriteLine("What category are you interested in? Animated, Horror, Comedy, or Drama?");
            string userInput = Console.ReadLine().ToLower();
           
                Movie.PrintMovieSelection(movies, userInput);
            Console.WriteLine("Would you like to continue?");
            string userAnswer = Console.ReadLine().ToLower();
            if (userAnswer == "y" || userAnswer == "yes")
            {
                willContinue = true;
            }
            else
            {
                willContinue = false;
                Console.WriteLine("Goodbye!");
            }
            } while (willContinue);
        }

    }
    }


//Question: why can't I create a new Class specifically to hold List of Movies
//the .Add function is not usable in a new class and new class does not recognize
//any List name I create ("does not exist in current context")
//also does not recognize "new" modifier.... frustrated....

/* using a dictionary prints "Movie.MovieApp" to console -- commenting out dictionary from code
to see if just printing straight from the Lists work
...update -- it did not work */

/*Dictionary<string, List<Movie>> allMovies = new Dictionary<string, List<Movie>>();
allMovies["Animated"] = AnimatedMovies;
allMovies["Horror"] = horror;
allMovies["Drama"] = DramaMovies;
allMovies["Comedy"] = ComedyMovies;*/
