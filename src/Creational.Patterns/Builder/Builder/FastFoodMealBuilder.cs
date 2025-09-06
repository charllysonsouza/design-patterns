using Builder.Model;

namespace Builder.Builder;

public class FastFoodMealBuilder
{
    private string _drink;
    private string _main;
    private string _side;
    private string _dessert;
    private string _gift;

    public FastFoodMealBuilder WithDrink(string drink)
    {
        _drink = drink;
        return this;
    }

    public FastFoodMealBuilder WithMain(string main)
    {
       _main = main;
        return this;
    }

    public FastFoodMealBuilder WithSide(string side)
    {
        _side = side;
        return this;
    }
    
    public FastFoodMealBuilder WithGift(string gift)
    {
        _gift = gift;
        return this;
    }

    public FastFoodMealBuilder WithDessert(string dessert)
    {
        _dessert = dessert;
        return this;
    }

    public FastFoodMeal Build()
    {
        return new FastFoodMeal(_drink, _main, _side, _dessert, _gift);
    }
}   