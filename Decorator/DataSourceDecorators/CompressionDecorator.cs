using Decorator.DataSource;

namespace Decorator.DataSourceDecorators;
class CompressionDecorator(IDataSource source) : DataSourceDecorator(source)
{
    public override void WriteData(string data)
    {
        string compressedData = Compress(data);
        base.WriteData(compressedData);
    }

    public override string ReadData()
    {
        string data = base.ReadData();
        return Decompress(data);
    }

    private static string Compress(string data)
    {
        return $"Compressed({data})";
    }

    private static string Decompress(string data)
    {
        return $"Decompressed({data})";
    }
}