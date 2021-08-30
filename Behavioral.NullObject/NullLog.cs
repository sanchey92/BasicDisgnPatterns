namespace Behavioral.NullObject
{
    public sealed class NullLog : ILog
    {
        public void Info(string message)
        {
        }

        public void Warn(string message)
        {
        }
    }
}