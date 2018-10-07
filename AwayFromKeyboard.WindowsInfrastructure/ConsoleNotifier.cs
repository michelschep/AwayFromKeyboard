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
        }

        public void StayAway()
        {
            throw new NotImplementedException();
        }

        public void StayHere()
        {
            throw new NotImplementedException();
        }
    }
}