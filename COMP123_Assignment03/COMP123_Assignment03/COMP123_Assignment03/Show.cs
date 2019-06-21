using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment03
{



    class Show
    {
        public double Price { get; }        
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        public Show(Movie movie, Day day, double price, Time time) {
            Price   = price;
            Day     = day;
            Movie   = movie; //TODO: should check it linked with the previous object or not
            Time    = time;
        }
        public override string ToString()
        {
            return $"Show: {Movie.Title} - Day: {Day} -Time: {Time} - Ticket Price: {Price}"; 
        }
    }
}
