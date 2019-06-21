using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment03
{
    enum Day
    {
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat,
        Sun,
    }


    /*
     *  None, Action, Romance, Documentary, Adult, Sci_Fi, Religious
     */
    [Flags]
    enum Genre
    {
        None        = 0,
        Action      = 1,
        Romance    = 2,
        Documentary = 4,
        Adult       = 8,
        Sci_Fi      = 16,
        Religious   = 32,
        Comedy      = 64,
        Horror      = 128,
        Fantasy     = 256,
        Adventure   = 512,
        Animation   = 1024

    }

    class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        //TODO: It should be public get because genre can not be set in Set Genre later
        public Genre Genre { get; private set; }
        public List<string> Cast { get; } = new List<string>();


        public Movie(string title, int year, int length) {
            Title = title;
            Year = year;
            Length = length;
        }

        public void AddActor(string actor) {
            Cast.Add(actor);
        }

        public void SetGenre(Genre genre) {
            Genre |= genre;
        }

        public override string ToString()
        {
            string result = $"{Title}";

            if (Cast.Count != 0)
            {
                result += " - ";
                foreach (string actor in Cast)
                {
                    result += actor + " ";
                }
            }
            return result;
        }
    }
}
