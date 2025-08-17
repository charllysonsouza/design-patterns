using Decorator.CoffeeShop;

namespace Decorator;

public class Tea : IDrink
{
    public void Serve()
    {
        Console.WriteLine("- Adding 100 ml of tea");
    }

    public double GetPrice()
    {
        return 1.0;
    }
}