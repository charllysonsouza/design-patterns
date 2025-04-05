using AbstractFactory.Factory;

namespace AbstractFactory.Model;

public abstract class IPhone(CountryRulesAbstractFactory countryRules)
{
    public abstract void GetHardware();

    public void Assemble() => Console.WriteLine("Assembling all the hardwares");

    public void Certificates()
    {
        Console.WriteLine("Certificating all the hardwares");
        countryRules.GetCertificates().ApplyCertification();
    }

    public void Pack()
    {
        Console.WriteLine("Packing all the hardwares");
        countryRules.GetPacking().Pack();
    }
}