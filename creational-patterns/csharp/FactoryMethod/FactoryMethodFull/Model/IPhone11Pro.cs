namespace FactoryMethodFull.model;

public class IPhone11Pro : IPhone
{
    public override void GetHardware()
    {
        Console.WriteLine("Hardware list");
        Console.WriteLine("\t- 6.5in Screen");
        Console.WriteLine("\t- A13 Chipset");
        Console.WriteLine("\t- 4GB Ram");
        Console.WriteLine("\t- 512Gb Memory");
    }
}