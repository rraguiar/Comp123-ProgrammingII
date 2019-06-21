using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //To write/read file.

namespace Medal
{
    //very good example of class with list of objects and file - IMPORTANT
    class Program
    {
        static void Main(string[] args)
        {
            //create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", "Gold", 2012, true);
            //print the object
            Console.WriteLine(m1);
            //print only the name of the medal holder
            Console.WriteLine(m1.Name);

            //create another object
            Medal m2 = new Medal("Michael Phelps", "Swimming", "Gold", 2012, false);
            //print the updated m2
            Console.WriteLine(m2);



            //create a list to store the medal objects
            List<Medal> medals = new List<Medal>() { m1, m2 };
            medals.Add(new Medal("Ryan Cochrane", "Swimming", "Silver", 2012, false));
            medals.Add(new Medal("Adam van Koeverden", "Canoeing", "Silver", 2012, false));
            medals.Add(new Medal("Rosie MacLennan", "Gymnastics", "Gold", 2012, false));
            medals.Add(new Medal("Christine Girard", "Weightlifting", "Bronze", 2012, false));
            medals.Add(new Medal("Charles Hamelin", "Short Track", "Gold", 2014, true));
            medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", "Gold", 2012, true));
            medals.Add(new Medal("Jennifer Jones", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Charle Cournoyer", "Short Track", "Bronze", 2014, false));
            medals.Add(new Medal("Mark McMorris", "Snowboarding", "Bronze", 2014, false));
            medals.Add(new Medal("Sidney Crosby ", "Ice Hockey", "Gold", 2014, false));
            medals.Add(new Medal("Brad Jacobs", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Ryan Fry", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Antoine Valois-Fortier", "Judo", "Bronze", 2012, false));
            medals.Add(new Medal("Brent Hayden", "Swimming", "Bronze", 2012, false));

            //prints a numbered list of 16 medals.
            Console.WriteLine("\n\nAll 16 medals");
            int cont = 1;
            foreach (Medal item in medals)
            {
                Console.WriteLine($"{cont} - {item}");
                cont++;
            }

            //prints a numbered list of 16 names
            Console.WriteLine("\n\nAll 16 names");
            cont = 1;
            foreach (Medal item in medals)
            {
                Console.WriteLine($"{cont} - {item.Name}");
                cont++;
            }

            //prints a numbered list of 9 gold medals
            Console.WriteLine("\n\nAll 9 gold medals");
            cont = 1;
            foreach (Medal item in medals)
            {
                if (item.Color == "Gold")
                {
                    Console.WriteLine($"{cont} - {item}");
                }
                cont++;
            }

            //prints a numbered list of 9 medals in 2012
            Console.WriteLine("\n\nAll 9 medals in 2012");
            cont = 1;
            foreach (Medal item in medals)
            {
                if (item.Year == 2012)
                {
                    Console.WriteLine($"{cont} - {item}");
                }
                cont++;
            }

            //prints a numbered list of 4 gold medals in 2012
            Console.WriteLine("\n\nAll 4 gold medals in 2012");
            cont = 1;
            foreach (Medal item in medals)
            {
                if (item.Color == "Gold" && item.Year == 2012)
                {
                    Console.WriteLine($"{cont} - {item}");
                }
                cont++;
            }

            //prints a numbered list of 3 world record medals
            Console.WriteLine("\n\nAll 3 records");
            foreach (Medal item in medals)
            {
                if (item.IsRecord == true)
                {
                    Console.WriteLine($"{cont} - {item}");
                }
                cont++;
            }

            //saving all the medal to file Medals.txt
            Console.WriteLine("\n\nSaving to file");
            TextWriter writer = new System.IO.StreamWriter("Medals.txt");
            foreach (Medal item in medals)
                writer.WriteLine(item);

            writer.Close();

            //reading from the file and putting on the screen:
            Console.WriteLine("\n\nReading from file");
            TextReader reader = new StreamReader("Medals.txt");
            string input = "";
            int lineNo = 1;
            while (input != null)
            {
                input = reader.ReadLine();
                if (input != null && input.Length != 0)
                {
                    Console.WriteLine($"{lineNo++} - {input}");
                }

            }
            reader.Close();
        }

    }
    class Medal
    {
        public string Name { get; }
        public string TheEvent { get; }
        public string Color { get; }
        public int Year { get; }
        public bool IsRecord { get; }

        public Medal(string Name, string TheEvent, string Color, int Year, bool IsRecord)
        {
            this.Name = Name;
            this.TheEvent = TheEvent;
            this.Color = Color;
            this.Year = Year;
            this.IsRecord = IsRecord;
        }
        public override string ToString()
        {
            string record;

            if (IsRecord == true)
                record = "(R)";
            else record = "";

            return $"{Year} - {TheEvent}{record} - {Name}({Color})";
        }
    }
}
