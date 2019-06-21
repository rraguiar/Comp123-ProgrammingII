using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment03
{
    class Theatre
    {
        List<Show> shows = new List<Show>();
        public string Name { get; }

        public Theatre(string name) {
            Name = name;
        }

        public void AddShow(Show show) {
            shows.Add(show);
        }

        public void PrintShows()
        {
            int i = 1;
            foreach (Show show in shows)
            {
                Console.Write($"{i++} ");
                Console.WriteLine(show);
            }
        }

        public void PrintShows(Time time)
        {
            int i = 1;
            foreach (Show show in shows)
            {                                
                if (show.Time == time)
                {
                    Console.Write($"{i++} ");
                    Console.WriteLine(show);
                }                
            }
        }

        public void PrintShows(Genre genre)
        {
            int i = 1;
            foreach (Show show in shows)
            {
                if (show.Movie.Genre.HasFlag(genre))
                {
                    Console.Write($"{i++} ");
                    Console.WriteLine(show);
                }
            }
        }

        public void PrintShows(Day day)
        {
            int i = 1;
            foreach (Show show in shows)
            {
                if (show.Day == day)
                {
                    Console.Write($"{i++} ");
                    Console.WriteLine(show);
                }
            }
        }

        public void PrintShows(string actor)
        {
            int i = 1;
            foreach (Show show in shows)
            {                
                if (show.Movie.Cast.Count != 0 
                    && show.Movie.Cast.Contains(actor))
                {
                    Console.Write($"{i++} ");
                    Console.WriteLine(show);
                }
            }
        }

        public void PrintShows(Day day, Time time)
        {
            int i = 1;
            foreach (Show show in shows)
            {
                if (show.Day == day && show.Time == time)
                {
                    Console.Write($"{i++} ");
                    Console.WriteLine(show);
                }
            }
        }
    }
}
