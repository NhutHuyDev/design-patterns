namespace AbstractFactory.UIComponent;
public class MacButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Rendering a button in Mac style.");
    }
}

public class MacCheckbox : ICheckBox
{
    public void Paint()
    {
        Console.WriteLine("Rendering a checkbox in Mac style.");
    }
}
