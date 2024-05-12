namespace Strategy;

public class Ticket
{
    private IPromoteStrategy promoteStrategy { get; set; }
    private double price { get; set; }
    private string name { get; set; }

    public Ticket(string name, double price, IPromoteStrategy promoteStrategy)
    {
        this.name = name;
        this.price = price;
        this.promoteStrategy = promoteStrategy;
    }

    public double GetPromotedPrice()
    {
        return promoteStrategy.DoDiscount(this.price);
    }

    public void PrintTicket()
    {
        Console.WriteLine($"ticket '{name}' - original price: {price} - promoted price: {GetPromotedPrice()}");
    }
}
