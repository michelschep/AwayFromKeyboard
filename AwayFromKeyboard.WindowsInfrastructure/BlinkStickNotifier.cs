using AwayFromKeyboard.Core.Interfaces;
using BlinkStickDotNet;

namespace AwayFromKeyboard.WindowsInfrastructure
{
    public class BlinkStickNotifier: INotifier
    {
        public void Report(string message)
        {
            
        }

        public void AdviceUserToGoForAWalk()
        {
            var led = BlinkStick.FindFirst();
            led.OpenDevice();
            
            led.Blink(RgbColor.FromString("red"), 3);
        }

        public void PleaseComeBack()
        {
            var led = BlinkStick.FindFirst();
            led.OpenDevice();

            led.Blink(RgbColor.FromString("blue"), 3);
        }

        public void StayAway()
        {
            var led = BlinkStick.FindFirst();
            led.OpenDevice();

            led.SetColor(RgbColor.FromString("green"));
        }

        public void StayHere()
        {
            var led = BlinkStick.FindFirst();
            led.OpenDevice();

            led.Blink(RgbColor.FromString("blue"), 2);
        }
    }
}
