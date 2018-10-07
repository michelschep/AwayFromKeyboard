using AwayFromKeyboard.Core.Interfaces;
using Microsoft.Win32;

namespace AwayFromKeyboard.WindowsInfrastructure
{
    public class Computer : IComputer
    {
        private bool _isLocked;

        public Computer()
        {
            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
        }

        public bool IsLocked()
        {
            return _isLocked;
        }

        void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionLock)
            {
                //I left my desk
                _isLocked = true;
            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock)
            {
                //I returned to my desk
                _isLocked = false;
            }
        }
    }
}