namespace FactoryMethod.Model;

public class IPhone15 : IPhone
{
    public override void GetHardware()
    {
        Console.WriteLine("Hardware list");
        Console.WriteLine("\t- 6.1in Screen");
        Console.WriteLine("\t- A13 Chipset");
        Console.WriteLine("\t- 4GB RAM");
        Console.WriteLine("\t- 256Gb Memory");
    }
}