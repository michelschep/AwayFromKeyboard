using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("And there we go!");

            var userCommand = Console.ReadLine();

            var client = new SocMedClient();
            client.Execute(userCommand);

            Console.WriteLine("Thx!");
            Console.ReadLine();
        }
    }

    class SocMedClient
    {
        public void Execute(string userCommand)
        {
            throw new NotImplementedException();
        }
    }
}
