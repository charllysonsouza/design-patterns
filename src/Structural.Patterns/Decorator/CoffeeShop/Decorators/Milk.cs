namespace Decorator.CoffeeShop.Decorators;

public class Milk(IDrink drink) : DrinkDecorator(drink)
{
    public override void Serve()
    {
        Drink.Serve();
        Console.WriteLine("- Adding 30 ml of Milk");
    }
    public override double GetPrice()
    {
        return Drink.GetPrice() + 0.5;
    }
}