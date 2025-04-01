namespace FactoryMethod.Model;

public abstract class IPhone
{
    public abstract void GetHardware();

    public void Assemble() => Console.WriteLine("Assembling all the hardwares");

    public void Certificates() => Console.WriteLine("Testing all the hardwares");
    
    public void Pack() => Console.WriteLine("Packing the device");
}