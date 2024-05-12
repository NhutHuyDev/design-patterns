using Strategy;

internal class Program
{
    private static void Main(string[] args)
    {
        var ticketA = new Ticket("NoDiscount", 1000.0, new NoDiscountStrategy());
        var ticketB = new Ticket("HalfDiscount", 1000.0, new HalfDiscountStrategy());
        var ticketC = new Ticket("QuarterDiscount", 1000.0, new QuarterDiscountStrategy());

        ticketA.PrintTicket();
        ticketB.PrintTicket();
        ticketC.PrintTicket();
    }
}