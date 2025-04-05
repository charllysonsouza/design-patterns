using AbstractFactory.Factory;

namespace AbstractFactory.Model;

public class IPhone16ProMax(CountryRulesAbstractFactory countryRules) : IPhone(countryRules)
{
    public override void GetHardware()
    {
        Console.WriteLine("Hardware list");
        Console.WriteLine("\t- 6.5in Screen");
        Console.WriteLine("\t- A14 Chipset");
        Console.WriteLine("\t- 8GB RAM");
        Console.WriteLine("\t- 512 Memory");
    }
}