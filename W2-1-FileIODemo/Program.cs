using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Step I -> include the necessary namespace



/*
 * Writing/Reading a file:
 * 
 * Step I -> include the necessary namespace:
 * using System.IO; at the library area
 * 
 * Step II -> Create an initialize the object to write to.... And to read to....
 * TextWriter writer = new StreamWriter (filename); // to write
 * TextReader reader = new StreamReader (filename); // to read
 * 
 * Step III -> Do your writing or reading
 * writer.Write("Hello world"); //to write
 * string input = reader.ReadLine(); //to read
 * Console.WriteLine(input); //to read
 * 
 * Step IV -> Close the object
 * Writer.Close(); //to close writer object and file
 * Reader.Close(); //to close reader object and filev
 */

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteFile("Text.txt");
            //ReadFile("Text.txt");
            ReadFile("Program.cs");
        }
        static void WriteFile (string filename)
        {
            TextWriter writer = new StreamWriter(filename); //Step II -> Create an initialize the object to write to

            //Step III -> Do your writing
            writer.Write("Hello ");
            writer.WriteLine(" from Rafael");
            for (int i=1;i<=12;i++)
            {
                writer.WriteLine($"{ i} x 3 = { i * 3}");
            }

            writer.Close(); //Step IV -> Close the object
        }
        static void ReadFile (string filename)
        {
            TextReader reader = new StreamReader(filename); //Step II -> Create an initialize the object to write read the file
            string input = "";
            int lineNo = 1;
            while (input!= null)
            {
                input = reader.ReadLine();
                Console.WriteLine($"{lineNo++} - {input}");
            }
            reader.Close();
        }
    }
}
