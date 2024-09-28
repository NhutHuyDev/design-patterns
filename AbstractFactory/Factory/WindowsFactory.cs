using AbstractFactory.UIComponent;

namespace AbstractFactory.Factory;
public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckBox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }
}