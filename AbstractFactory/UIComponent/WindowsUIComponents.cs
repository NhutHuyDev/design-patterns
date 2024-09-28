namespace AbstractFactory.UIComponent;

public class WindowsButton : IButton
    {
    public void Paint()
    {
        Console.WriteLine("Rendering a button in Windows style.");
    }
}

public class WindowsCheckbox : ICheckBox
{
    public void Paint()
    {
        Console.WriteLine("Rendering a checkbox in Windows style.");
    }
}
