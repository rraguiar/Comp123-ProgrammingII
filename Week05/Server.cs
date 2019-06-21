using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05
{
    class Server
    {
        protected List<string> duties = new List<string>();
        protected double wages;
        public string Name { get; }

        public Server(string name)
        {
            Name = name;
            wages = 14.95;
            string[] Duties = { "cashier", "clean", "attend customers", "cook" };
            duties.AddRange(Duties);
        }
        public override string ToString()
        {
            /*
             * 
            string foreachDuties="";
            foreach (string item in duties)
            {
                foreachDuties += $" {item},";
            }
            return $"I am {Name}, and my duties are: {foreachDuties}";
            */
            return $"I am {Name}, I make {wages:c}/hr, and my duties: {String.Join(", ", duties)}";
        }
    }
    class Supervisor : Server
    {
        public Supervisor(string name) :base(name)
        {
            wages = 18.25;
            duties.Add("Train servers");
        }
    }
    class Manager:Supervisor
    {
        public Manager (string name):base(name)
        {
            wages = 25.75;
            duties.Add("Manage inventory");
        }
    }
}
