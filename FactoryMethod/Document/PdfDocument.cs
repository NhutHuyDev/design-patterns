namespace FactoryMethod;

public class PdfDocument : IDocument
{
    public void open()
    {
        Console.WriteLine("Implement open() for PDF file");
    }

    public void read()
    {
        Console.WriteLine("Implement read() for PDF file");
    }

    public void close()
    {
        Console.WriteLine("Implement close() for PDF file");
    }

}
