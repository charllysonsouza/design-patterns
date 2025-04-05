using AbstractFactory.Enums;
using AbstractFactory.Model;

namespace AbstractFactory.Factory;

public abstract class IPhoneFactory
{
    public IPhone? OrderIphone(IPhoneLevel level, CountryRulesAbstractFactory countryRules)
    {
        var device = CreateIPhone(level, countryRules);

        if (device == null) return device;
        
        device.Assemble();
        device.GetHardware();
        device.Certificates();
        device.Pack();

        return device;
    }
    
    protected abstract IPhone? CreateIPhone(IPhoneLevel level, CountryRulesAbstractFactory countryRules);
}