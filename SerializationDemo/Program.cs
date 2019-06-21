using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization; //step 2 - adding library for serialization
using System.IO;

namespace SerializationDemo
{
    //serialization with using and reference
    class Program
    {
        static void Main(string[] args)
        {
            List<Lizard> lizards = Lizard.GetLizards();
            //SerializeOneLizard("one.json", lizards[0]);
            //SerializeLizards("two.json", lizards);
            DeserializeOneLizard("one.json");
            DeserializeLizards("two.json");
        }
        static void DeserializeOneLizard(string filename)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (TextReader reader = new StreamReader(filename))
            {
                //read the file and store into a string
                string data = reader.ReadToEnd();

                //data cast to LIZARD, deserialize and store on the Lizard list.
                Lizard lizard = serializer.Deserialize<Lizard>(data);

                Console.WriteLine(lizard);
            }
        }
        static void DeserializeLizards(string filename)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (TextReader reader = new StreamReader(filename))
            {
                string data = reader.ReadToEnd();
                List <Lizard>lizards = serializer.Deserialize<List<Lizard>>(data);
                foreach (Lizard lizard in lizards)
                {
                    Console.WriteLine(lizard);
                }
            }
        }
        static void SerializeOneLizard(string filename, Lizard lizard)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (TextWriter writer = new StreamWriter(filename))
            {
                string result = serializer.Serialize(lizard);
                writer.WriteLine(result);
            }
        }
        static void SerializeLizards(string filename, List<Lizard> lizards)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (TextWriter writer = new StreamWriter(filename))
            {
                string result = serializer.Serialize(lizards);
                writer.Write(result);
            }
        }
    }
    class Lizard
    {
        public string Species;
        public int Quantity;
        public bool IsDangerous;
        public override string ToString()
        {
            return string.Format($"{Species} {Quantity} {(IsDangerous ? "dangerous" : "not dangerous")}");
        }
        public static List<Lizard> GetLizards()
        {
            return new List<Lizard>()
            {
                new Lizard() { Species = "Leopard gecko", Quantity = 3, IsDangerous = true },
                new Lizard() { Species = "Bearded dragon", Quantity = 1, IsDangerous = true },
                new Lizard() { Species = "Crested gecko", Quantity = 4, IsDangerous = false },
                new Lizard() { Species = "Argentine tegu", Quantity = 4, IsDangerous = true },
                new Lizard() { Species = "Thorny devil", Quantity = 4, IsDangerous = true },
                new Lizard() { Species = "Casquehead lizard", Quantity = 4, IsDangerous = true },
                new Lizard() { Species = "Panther chameleon", Quantity = 6, IsDangerous = false },
                new Lizard() { Species = "Veiled chameleon", Quantity = 4, IsDangerous = true },
                new Lizard() { Species = "Water monitor", Quantity = 4, IsDangerous = false },
                new Lizard() { Species = "Komodo dragon", Quantity = 4, IsDangerous = true },
                new Lizard() { Species = "Green iguana", Quantity = 4, IsDangerous = false },
                new Lizard() { Species = "Blotched blue-tongue lizard", Quantity = 4, IsDangerous = true },
                new Lizard() { Species = "Gila monster", Quantity = 4, IsDangerous = true }
            };
        }
    }
}