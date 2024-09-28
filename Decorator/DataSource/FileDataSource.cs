using Decorator.DataSource;

class FileDataSource(string fileName) : IDataSource
{
    private readonly string fileName = fileName;

    public string ReadData()
    {
        return $"""Read raw data from {this.fileName}""";
    }

    public void WriteData(string data)
    {
        Console.WriteLine(data);
    }
}