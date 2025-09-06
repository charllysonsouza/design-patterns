namespace Builder.Model;

public class FastFoodMeal
{
    private string Main { get; }
    private string Side { get; }
    private string Gift { get; }
    private string Dessert { get; }
    private string Drink { get; }

    public FastFoodMeal(string drink, string main, string side, string dessert, string gift)
    {
        Main = main;
        Side = side;
        Gift = gift;
        Dessert = dessert;
        Gift = gift;
        Drink = drink;
    }
    
    public override string ToString()
    {
        return $"Meal:\n -- Main: {Main}\n -- Side: {Side}\n -- Gift: {Gift}\n -- Dessert: {Dessert}\n -- Drink: {Drink}\n";
    }
}