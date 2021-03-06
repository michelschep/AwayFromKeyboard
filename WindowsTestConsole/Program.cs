﻿using System;
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

            var blinkStickNotifier = new ForgivingNotifier(new BlinkStickNotifier());
            var consoleNotifier = new ForgivingNotifier(new ConsoleNotifier());
            var multipleNotifiers = new MultipleNotifier(blinkStickNotifier, consoleNotifier);
            var healthService = new HealthService(new Computer(), multipleNotifiers, new Clock());
            healthService.Start();

            Console.WriteLine("Health Service Running");
            Console.ReadLine();
            healthService.Stop();
        }
    }
}
