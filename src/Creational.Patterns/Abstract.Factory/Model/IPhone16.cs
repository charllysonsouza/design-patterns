using AbstractFactory.Factory;

namespace AbstractFactory.Model;

public class IPhone16(CountryRulesAbstractFactory countryRules) : IPhone(countryRules)
{
    public override void GetHardware()
    {
        Console.WriteLine("Hardware list");
        Console.WriteLine("\t- 6.3in Screen");
        Console.WriteLine("\t- A13 Chipset");
        Console.WriteLine("\t- 6GB RAM");
        Console.WriteLine("\t- 512 Memory");
    }
}