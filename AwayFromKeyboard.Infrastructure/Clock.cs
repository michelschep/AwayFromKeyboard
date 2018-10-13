using System;
using AwayFromKeyboard.Core.Interfaces;

namespace AwayFromKeyboard.Infrastructure
{
    public class Clock:IClock
    {
        public DateTimeOffset Now()
        {
            return DateTimeOffset.Now;
        }
    }
}