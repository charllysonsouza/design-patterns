namespace FactoryMethodFull.model;

public class IPhoneX : IPhone
{
    public override void GetHardware()
    {
        Console.WriteLine("Hardware list");
        Console.WriteLine("\t- 5.8in Screen");
        Console.WriteLine("\t- A11 Chipset");
        Console.WriteLine("\t- 3GB Ram");
        Console.WriteLine("\t- 256Gb Memory");
    }
}