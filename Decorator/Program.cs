using Decorator.DataSource;
using Decorator.DataSourceDecorators;

namespace Decorator;

class Program
{
    static void Main(string[] args)
    {
        string passwordRecord = "(John Smith, johnSmith, john@2024)";

        IDataSource source = new FileDataSource("passwordRecords.txt");

        source = new CompressionDecorator(new EncryptionDecorator(source));

        source.WriteData(passwordRecord);
    
        Console.WriteLine(source.ReadData());
    }
}
