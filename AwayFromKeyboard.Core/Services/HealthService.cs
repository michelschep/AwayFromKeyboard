using System;
using System.Threading.Tasks;
using AwayFromKeyboard.Core.Interfaces;

namespace AwayFromKeyboard.Core.Services
{
    public class HealthService
    {
        private readonly IComputer _computer;
        private readonly INotifier _notifier;
        private readonly IClock _clock;

        public HealthService(IComputer computer, INotifier notifier, IClock clock)
        {
            _computer = computer ?? throw new ArgumentNullException(nameof(computer));
            _notifier = notifier ?? throw new ArgumentNullException(nameof(notifier));
            _clock = clock ?? throw new ArgumentNullException(nameof(clock));
        }

        public void Start()
        {
            var wasLocked = false;
            var lastTimeUnlocked = _clock.Now();
            var lastTimeLocked = lastTimeUnlocked.AddMinutes(-1);

            while (true)
            {
                Task.Delay(30*1000).Wait();

                if (wasLocked)
                {
                    if (_computer.IsLocked())
                    {
                        if (TimeComputerIsLocked(lastTimeLocked).Minutes >= 2)
                            _notifier.PleaseComeBack();
                        else
                            _notifier.StayAway();
                    }
                    else
                    {
                        wasLocked = false;
                        ;
                        lastTimeUnlocked = _clock.Now();
                        _notifier.StayHere();
                    }
                }
                else
                {
                    if (!_computer.IsLocked())
                    {
                        if (TimeComputerUnlocked(lastTimeUnlocked).Minutes >= 20)
                        {
                            _notifier.AdviceUserToGoForAWalk();
                        }
                        else
                        {
                            _notifier.StayHere();
                        }
                    }
                    else
                    {
                        wasLocked = true;
                        lastTimeLocked = _clock.Now();
                        _notifier.StayAway();
                    }
                }
            }
        }

        private TimeSpan TimeComputerUnlocked(DateTimeOffset lastTimeUnlocked)
        {
            return _clock.Now() - lastTimeUnlocked;
        }

        private TimeSpan TimeComputerIsLocked(DateTimeOffset lastTimeLocked)
        {
            return _clock.Now() - lastTimeLocked;
        }

        public void Stop()
        {
        }
    }
}
