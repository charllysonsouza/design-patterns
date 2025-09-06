using Builder.Builder;
using Builder.Model;

FastFoodMeal burgerCombo = new FastFoodMealBuilder()
    .WithMain("CheeseBurger")
    .WithSide("Fries")
    .WithDrink("Coke")
    .Build();
Console.WriteLine(burgerCombo);

FastFoodMeal justFries = new FastFoodMealBuilder()
    .WithSide("Fries")
    .Build();
Console.WriteLine(justFries);

FastFoodMeal heartAttackCombo = new FastFoodMealBuilder()
    .WithMain("Monster burger")
    .WithDrink("MilkShake")
    .WithDessert("Large Ice Cream")
    .WithGift("2 Kilograms")
    .Build();
Console.WriteLine(heartAttackCombo);