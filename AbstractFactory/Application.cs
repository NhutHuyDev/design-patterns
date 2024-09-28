using AbstractFactory.Factory;
using AbstractFactory.UIComponent;

namespace AbstractFactory;
public class Application
{
    private IButton _button;
    private ICheckBox _checkbox;

    public Application(IGUIFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
    }

    public void Paint()
    {
        _button.Paint();
        _checkbox.Paint();
    }
}