namespace FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        // Word document 
        DocumentFactory documentFactoryA = new WordDocumentFactory();
        IDocument documentA = documentFactoryA.CreateDocument();
        documentA.open();
        documentA.read();
        documentA.close();

        // PDF document 
        DocumentFactory documentFactoryB = new PdfDocumentFactory();
        IDocument documentB = documentFactoryB.CreateDocument();
        documentB.open();
        documentB.read();
        documentB.close();
    }
}
