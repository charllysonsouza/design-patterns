namespace Decorator.CoffeeShop;

public class Espresso : IDrink
{
    public void Serve()
    {
        Console.WriteLine("- Adding 50 ml of espresso");
    }

    public double GetPrice()
    {
        return 1.5;
    }
}