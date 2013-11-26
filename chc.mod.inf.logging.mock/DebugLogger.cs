namespace chc.mod.inf.logging.mock
{
    using System.Diagnostics;

    public class DebugLogger : ILogger
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
