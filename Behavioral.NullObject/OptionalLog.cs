namespace Behavioral.NullObject
{
    public class OptionalLog : ILog
    {
        private readonly ILog _impl;

        public OptionalLog(ILog impl)
        {
            _impl = impl;
        }

        public void Info(string message) => _impl?.Info(message);

        public void Warn(string message) => _impl?.Warn(message);
    }
}