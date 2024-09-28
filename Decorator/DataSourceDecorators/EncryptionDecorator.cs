using Decorator.DataSource;

namespace Decorator.DataSourceDecorators;
class EncryptionDecorator(IDataSource source) : DataSourceDecorator(source)
{
    public override void WriteData(string data)
    {
        string encryptedData = Encrypt(data);
        base.WriteData(encryptedData);
    }

    public override string ReadData()
    {
        string data = base.ReadData();
        return Decrypt(data);
    }

    private static string Encrypt(string data)
    {
        return $"Encrypted({data})";
    }

    private static string Decrypt(string data)
    {
        return $"Decrypted({data})";
    }
}
