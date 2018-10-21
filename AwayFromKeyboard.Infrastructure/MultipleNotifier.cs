using System;
using AwayFromKeyboard.Core.Interfaces;

namespace AwayFromKeyboard.Infrastructure
{
    public class MultipleNotifier: INotifier
    {
        private readonly INotifier[] _notifiers;

        public MultipleNotifier(params INotifier[] notifiers)
        {
            _notifiers = notifiers ?? throw new ArgumentNullException(nameof(notifiers));
        }

        public void Report(string message)
        {
            foreach (var notifier in _notifiers)
            {
                notifier.Report(message);
            }
        }

        public void AdviceUserToGoForAWalk()
        {
            foreach (var notifier in _notifiers)
            {
                notifier.AdviceUserToGoForAWalk();
            }
        }

        public void PleaseComeBack()
        {
            foreach (var notifier in _notifiers)
            {
                notifier.PleaseComeBack();
            }
        }

        public void StayAway()
        {
            foreach (var notifier in _notifiers)
            {
                notifier.StayAway();
            }
        }

        public void StayHere()
        {
            foreach (var notifier in _notifiers)
            {
                notifier.StayHere();
            }
        }
    }
}