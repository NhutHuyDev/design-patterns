using Decorator.DataSource;
namespace Decorator.DataSourceDecorators;

class DataSourceDecorator(IDataSource source) : IDataSource
{
    private readonly IDataSource wrappee = source;

    public virtual string ReadData()
    {
        return this.wrappee.ReadData();
    }

    public virtual void WriteData(string data)
    {
        this.wrappee.WriteData(data);
    }
}