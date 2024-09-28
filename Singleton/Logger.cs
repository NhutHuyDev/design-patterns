namespace Singleton;
public class Logger
{
    private static Logger? instance;
    private static readonly object lockObject = new();
    private readonly string logFilePath;

    private Logger()
    {
        logFilePath = "log.txt";
    }

    public static Logger GetInstance()
    {
        lock (lockObject)
        {
            if (instance == null)
            {
                instance = new Logger();
            }
        }
        return instance;
    }

    public void Log(string message)
    {
        lock (lockObject)
        {
            using (StreamWriter writer = new(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
        Console.WriteLine($"Logged: {message}");
    }
}
