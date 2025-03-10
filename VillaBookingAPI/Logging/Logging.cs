namespace VillaBookingAPI.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            // Log message
            if(type == "error")
            {
                // Log error
                Console.WriteLine("Error - " + message);
            } else
            {
                // Log info
                Console.WriteLine(message);
            }
        }
    }
    public class LoggingV2 : ILogging
    {
        public void Log(string message, string type)
        {
            // Log message
            if (type == "error")
            {
                // Log error
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Error - " + message);
                Console.BackgroundColor = ConsoleColor.Black;   
            }
            else
            {
                if (type == "warning")
                {
                    // Log warning
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Warning - " + message);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    // Log info
                    Console.WriteLine(message);
                }
            }
        }
    }
}
