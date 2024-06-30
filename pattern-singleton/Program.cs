using pattern_singleton.Logger;

namespace pattern_singleton
{
    public class Program
    {
        protected Program() { }
        static void Main()
        {
            LoggerI logger = LoggerI.Instance;

            logger.Log("Starting application...");

            for (int i = 0; i < 5; i++)
                logger.Log($"Logging event {i}");

            logger.Log("Ending application...");
        }
    }
}
