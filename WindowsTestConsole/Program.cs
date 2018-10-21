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
            Console.WriteLine("Start Heath Service");

            var notifier = new ForgivingNotifier(new BlinkStickNotifier());
            var healthService = new HealthService(new Computer(), notifier, new Clock());
            healthService.Start();

            Console.WriteLine("Health Service Running");
            Console.ReadLine();
            healthService.Stop();
        }
    }
}
