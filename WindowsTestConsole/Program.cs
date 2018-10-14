using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwayFromKeyboard.Core.Services;
using AwayFromKeyboard.Infrastructure;
using AwayFromKeyboard.WindowsInfrastructure;

namespace WindowsTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var healthService = new HealthService(new Computer(), new BlinkStickNotifier(), new Clock());
            healthService.Start();

            Console.WriteLine("Health Service Running");
            Console.ReadLine();
            healthService.Stop();
        }
    }
}
