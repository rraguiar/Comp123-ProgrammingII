using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05
{
    class Program
    {
        static void Main(string[] args)
        {
            Server employeeServer = new Server("Server");
            Console.WriteLine(employeeServer);
            Console.WriteLine(new Supervisor("Anmolpreet"));
            Console.WriteLine(new Manager("Pritpal"));
        }
    }
}
