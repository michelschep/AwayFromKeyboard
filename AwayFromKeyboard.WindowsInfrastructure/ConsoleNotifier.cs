using System;
using AwayFromKeyboard.Core.Interfaces;

namespace AwayFromKeyboard.WindowsInfrastructure
{
    public class ConsoleNotifier: INotifier
    {
        public void Report(string message)
        {
            Console.WriteLine(message);
        }

        public void AdviceUserToGoForAWalk()
        {
            Console.WriteLine("Go for a walk!");
        }

        public void PleaseComeBack()
        {
            Console.WriteLine("Please come back");
        }

        public void StayAway()
        {
            Console.WriteLine("Stay away");
        }

        public void StayHere()
        {
            Console.WriteLine("Stay here");
        }
    }
}