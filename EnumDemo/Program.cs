using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    //example of enum with bit field - set of flags
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun};
    [Flags]
    enum Genre { None=0, Comedy=1, Action=2, Documentary=4, Romance=8, Adult=16, SciFi=32, Drama=64, Thriller=128}
    class Program
    {
        static void Main(string[] args)
        {
            //DayDemo();
            GenreDemo();
        }
        static void GenreDemo()
        {
            Genre genre = Genre.Comedy;
            Console.WriteLine(genre);
            if (genre==Genre.Documentary)
            {
                Console.WriteLine("it is a documentary");
            }
            else
            {
                Console.WriteLine("it is not a documentary");
            }

            genre = Genre.Drama | Genre.Action|Genre.Comedy;
            Console.WriteLine(genre);

            Console.WriteLine($"{(genre.HasFlag(Genre.Comedy) ? "COMEDY" : "NOT COMEDY")}");
            
        }
        static void DayDemo()
        {
            Day today = Day.Wed;
            Console.WriteLine($"-> {today}");
        }
    }
}
