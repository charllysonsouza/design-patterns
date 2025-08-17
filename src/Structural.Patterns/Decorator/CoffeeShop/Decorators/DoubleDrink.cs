namespace Decorator.CoffeeShop.Decorators;

public class DoubleDrink(IDrink drink) :  DrinkDecorator(drink)
{
    public override void Serve()
    {
        Drink.Serve();
        Drink.Serve();
    }

    public override double GetPrice()
    {
        return drink.GetPrice() * 1.75;
    }
}