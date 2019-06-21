using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

/* COMP123 - Programming2
 * 
 * Rafael Aguiar
 * 301041266
 * 
 * Test1 - Tutor_b
 */
namespace _301041266_RafaelAguiar_Test_Tutor_b
{
    enum Day { Mon, Tue, Wed, Thu, Fri };
    class Program
    {
        static void Main(string[] args)
        {

            //checking the tutor constructor
            Console.WriteLine("Checking tutor constructor");
            Tutor tutor = new Tutor(new Name() { first = "Milanpreet", last = "Singh" }, Day.Mon, new string[] { "COMP100", "COMP213" });
            Console.WriteLine(tutor);
            //tutor.AddCourse("COMP391");
            //tutor.SetRate(3);
            Console.WriteLine(tutor);
            //To show all the tutors
            Console.WriteLine($"\n\nAll tutors:");
            //To show tutors available on Monday
            Day day = Day.Mon;
            Console.WriteLine($"\n\nTutors available on {day}:");
            //To show tutors available for COMP125
            string course = "COMP125";
            Console.WriteLine($"\n\nTutors available for {course}:");
            Name name = new Name() { first = "Rana" };
            Console.WriteLine($"\n\nTutors name {name}:");
            //To show tutors with rating above 2
            int rate = 2;
            Console.WriteLine($"\n\nTutors with rating above {rate}:");
            //To saving all tutor to a json file
            string file = "tutor.json";
            Console.WriteLine($"\n\nSaving all tutors to file {file}");

        }
    }

    struct Name
    {
        public string first;
        public string last;

        public override string ToString()
        {
            return $"{first} {last}";
        }
    }

    class Tutor
    {
        public Day Availability { get; }
        public List<string> Courses { get; }
        public string Name { get; }
        public int Rate { get; }
        public Tutor(Name name, Day availability, string[] courses, int rate = 2)
        {
            List<string> Courses = new List<string>();
            for (int i = 0; i < courses.Length; i++)
            {
                Courses.Add(courses[i]);
            }
            
            this.Name = name.ToString();
            this.Rate = rate;
            this.Availability = availability;
        }

        public override string ToString()
        {
            return $"{Name} [{Rate}] available on {Availability} for {Courses}";
        }
        public void AddCourse(string course)
        {            
                Courses.Add(course);
        }
    }

    static class TutorManager
    {
        private static List<Tutor> tutors;

        static TutorManager()
        {
            List<Tutor> tutors = new List<Tutor> {
                new Tutor (new Name() {first = "Taranpreet", last = "Singh" }, Day.Mon, new string[] { "COMP100", "COMP125" }, 1),
                new Tutor (new Name() {first = "Pritpal" }, Day.Tue, new string[] { "COMP100", "COMP123" },4),
                new Tutor (new Name() {first = "Liya" }, Day.Wed, new string[] { "COMP229", "COMP123" },1),
                new Tutor (new Name() {first = "Lipeng" }, Day.Mon, new string[] { "COMP100", "COMP125" },2),
                new Tutor (new Name() {first = "Ashleen", last = "Rana" }, Day.Fri, new string[] { "COMP100", "COMP123" },3),
                new Tutor (new Name() {first = "Andrew" }, Day.Tue, new string[] { "COMP229", "COMP123" },1),
                new Tutor (new Name() {first = "Sanampreet" }, Day.Thu, new string[] { "COMP100", "COMP125" },1),
                new Tutor (new Name() {first = "Andrey" }, Day.Wed, new string[] { "COMP100", "COMP123" },1),
                new Tutor (new Name() {first = "Kryselle" }, Day.Tue, new string[] { "COMP229", "COMP123" },3),
                new Tutor (new Name() {first = "Rana", last = "Reezok" }, Day.Mon, new string[] { "COMP112", "COMP123" },1),
            };
        }
        public static void Add(Tutor tutor)
        {
            tutors.Add(tutor);
        }
        public static void Show()
        {
            int count = 1;
            foreach (Tutor item in tutors)
            {
                Console.Write($"{count} - {item}");
                count++;
            }
        }

        /* This method displays all the tutor
objects in the collection whose are availability on the specified day as a numbered list.*/
        public static void Show(Day availability)
        {
            int count = 1;
            foreach (Tutor item in tutors)
            {
                if (item.Availability == availability)
                {
                    Console.Write($"{count} - {item}");
                    count++;
                }
            }
        }

        /* – This method displays all the tutor objects
in the collection who are able to provide assistance for the specified course as the argument as
a numbered list.*/
        public static void Show(string course)
        {
            int count = 1;
            foreach (Tutor item in tutors)
            {
                if (item.Courses[0] == course || item.Courses[1] == course)
                {
                    Console.Write($"{count} - {item}");
                    count++;
                }
            }
        }
        /* – This method
displays all the tutor objects in the collection who are available on the specified day to provide
assistance for the specified course by the argument as a numbered list.*/
        public static void Show(Day availability, string course)
        {
            int count = 1;
            foreach (Tutor item in tutors)
            {
                if (item.Availability == availability)
                {
                    if (item.Courses[0] == course || item.Courses[1] == course)
                    {
                        Console.Write($"{count} - {item}");
                        count++;
                    }
                }
            }
        }
        /* – This method displays all the tutor objects in the
collection who has a rating higher that the specified value as a numbered list.*/

        public static void Show(int rate)
        {
            int count = 1;
            foreach (Tutor item in tutors)
            {
                if (item.Rate == rate)
                {
                    Console.Write($"{count} - {item}");
                    count++;
                }
            }
        }

        /* – This method saves all the pet objects
in the collection that as a json object to the specified file.*/

        public static void Save(string filename)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (TextWriter writer = new StreamWriter(filename))
            {
                string result = serializer.Serialize(tutors);
                writer.Write(result);
            }
        }
    }
}
 
 