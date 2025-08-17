namespace Decorator.CoffeeShop.Decorators;

public abstract class DrinkDecorator(IDrink drink) : IDrink
{
    protected readonly IDrink Drink = drink;
    
    public abstract void Serve();
    public abstract double GetPrice();
}