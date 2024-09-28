namespace Singleton;
class Program
{
    static void Main(string[] args)
    {
        // Logger logger1 = Logger.GetInstance();
        // logger1.Log("Written by logger 1.");

        // Logger logger2 = Logger.GetInstance();
        // logger2.Log("Written by logger 2.");

        // Kiểm tra xem cả hai logger có trỏ cùng đến một địa chỉ không
        // Console.WriteLine($"Same instance: {object.ReferenceEquals(logger1, logger2)}");

        Parallel.For(0, 10, i =>
        {
            Logger logger = Logger.GetInstance();
            logger.Log($"Log from thread {i}");
        });
    }
}
