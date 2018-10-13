using System;
using AwayFromKeyboard.Core.Interfaces;

namespace AwayFromKeyboard.Infrastructure
{
    public class ForgivingNotifier : INotifier
    {
        private readonly INotifier _notifier;

        public ForgivingNotifier(INotifier notifier)
        {
            _notifier = notifier ?? throw new ArgumentNullException(nameof(notifier));
        }

        public void Report(string message)
        {
            try
            {
                _notifier.Report(message);
            }
            catch (Exception e)
            {
            }
        }

        public void AdviceUserToGoForAWalk()
        {
            try
            {
                _notifier.AdviceUserToGoForAWalk();
            }
            catch (Exception e)
            {
            }
        }

        public void PleaseComeBack()
        {
            try
            {
                _notifier.PleaseComeBack();
            }
            catch (Exception e)
            {
            }
        }

        public void StayAway()
        {
            try
            {
                _notifier.StayAway();
            }
            catch (Exception e)
            {
            }
        }

        public void StayHere()
        {
            try
            {
                _notifier.StayHere();
            }
            catch (Exception e)
            {
            }
        }
    }
}