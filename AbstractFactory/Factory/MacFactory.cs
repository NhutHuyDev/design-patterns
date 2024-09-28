using AbstractFactory.Factory;
using AbstractFactory.UIComponent;

namespace AbstractFactory.Factory;

public class MacFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckBox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}