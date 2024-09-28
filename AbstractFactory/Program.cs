using AbstractFactory.Factory;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WindowsFactory
            IGUIFactory windowsFactory = new WindowsFactory();
            Application windowsApp = new(windowsFactory);
            windowsApp.Paint();  // Output: Rendering a button and checkbox in Windows style.

            // MacFactory
            IGUIFactory macFactory = new MacFactory();
            Application macApp = new(macFactory);
            macApp.Paint();  // Output: Rendering a button and checkbox in Mac style.
        }
    }
}
