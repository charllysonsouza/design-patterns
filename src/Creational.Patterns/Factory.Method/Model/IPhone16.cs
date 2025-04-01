namespace FactoryMethod.Model;

public class IPhone16 : IPhone
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