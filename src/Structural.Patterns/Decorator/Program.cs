// See https://aka.ms/new-console-template for more information

using Decorator;
using Decorator.CoffeeShop;
using Decorator.CoffeeShop.Decorators;

Console.WriteLine("##### Ordering an espresso #####");
IDrink espresso = new Espresso();
espresso.Serve();
Console.WriteLine("Total: R$ " +  espresso.GetPrice());
Console.WriteLine("------------");

Console.WriteLine("##### Ordering a tea #####");
IDrink tea = new Tea();
tea.Serve();
Console.WriteLine("Total: R$ " +  tea.GetPrice());
Console.WriteLine("------------");

Console.WriteLine("##### Ordering a Lungo #####");
IDrink lungo = new DoubleDrink(new Espresso());
lungo.Serve();
Console.WriteLine("Total: R$ " +  lungo.GetPrice());
Console.WriteLine("------------");

Console.WriteLine("##### Ordering a Cafe Au Lait #####");
IDrink cafeAuLait = new Milk(new Espresso());
cafeAuLait.Serve();
Console.WriteLine("Total: R$ " +  cafeAuLait.GetPrice());
Console.WriteLine("------------");

Console.WriteLine("##### Ordering an english tea #####");
IDrink englishTea = new Milk(new Tea());
englishTea.Serve();
Console.WriteLine("Total: R$ " +  englishTea.GetPrice());