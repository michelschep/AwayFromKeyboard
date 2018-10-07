using System;
using AwayFromKeyboard.Core.Interfaces;

namespace AwayFromKeyboard.WindowsInfrastructure
{
    public class Clock:IClock
    {
        public DateTimeOffset Now()
        {
            return DateTimeOffset.Now;
        }
    }
}