using AbstractFactory.UIComponent;

namespace AbstractFactory.Factory;

public interface IGUIFactory
{
    IButton CreateButton();
    ICheckBox CreateCheckbox();
}
