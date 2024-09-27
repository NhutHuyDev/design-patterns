namespace FactoryMethod;

public class WordDocument : IDocument
{
    public void open()
    {
        Console.WriteLine("Implement open() for Word file");
    }

    public void read()
    {
        Console.WriteLine("Implement read() for Word file");
    }

    public void close()
    {
        Console.WriteLine("Implement close() for Word file");
    }
}
