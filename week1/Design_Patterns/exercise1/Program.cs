using System;

public class Logger
{
    // Private static instance of Logger class
    private static Logger _instance;

    // Private constructor to prevent instantiation
    private Logger() 
    {
        Console.WriteLine("Logger instance created.");
    }

    // Public static method to get the instance
    public static Logger GetInstance()
    {
        // Create the instance if it doesn't exist
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    // Method to log messages
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get the Logger instance
        Logger logger1 = Logger.GetInstance();
        logger1.Log("This is the first log message.");

        // Get the same Logger instance
        Logger logger2 = Logger.GetInstance();
        logger2.Log("This is the second log message.");

        // Check if both instances are the same
        if (logger1 == logger2)
        {
            Console.WriteLine("Singleton pattern is working. Both logger1 and logger2 are the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton pattern failed. Different instances were created.");
        }
    }
}
