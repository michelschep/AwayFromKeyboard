using System;

namespace AwayFromKeyboard.Core.Interfaces
{
    public interface IClock
    {
        DateTimeOffset Now();
    }
}