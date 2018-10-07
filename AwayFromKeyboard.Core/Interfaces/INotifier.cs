namespace AwayFromKeyboard.Core.Interfaces
{
    public interface INotifier
    {
        void Report(string message);
        void AdviceUserToGoForAWalk();
        void PleaseComeBack();
        void StayAway();
        void StayHere();
    }
}