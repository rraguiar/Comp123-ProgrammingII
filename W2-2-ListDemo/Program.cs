using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IntListDemo();
            //StringListDemo();
        }

        static void StringListDemo()
        {
            //example of declaring a list and loading values to it.
            List<string> pms = new List<string> {"Trudeau", "Harper", "Martin", "Chretien", "Campbell", "Singh"};
            Console.WriteLine("Writing all the list:\b"+pms);
            Console.WriteLine("Writing each item on the list:");
            foreach (string item in pms)
            {
                Console.WriteLine(item);
            }
            pms.Insert(3, "King");
            for (int i=0; i<pms.Count; i++)
            {
                if (pms[i].StartsWith("C"))
                {
                    pms.RemoveAt(i);
                    i--;
                }
            }
            foreach (string pm in pms)
            {
                Console.Write(pm +", ");
            }
        }

        static void IntListDemo()
        {
            List<int> numbers = new List<int>();//creates an empty list
            //loop to add 5, 10, 15... until 100 to the list
            for (int i=5; i<101;i+=5)
            {
                numbers.Add(i);
            }
            //print all the items in the collection
            foreach (int item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
