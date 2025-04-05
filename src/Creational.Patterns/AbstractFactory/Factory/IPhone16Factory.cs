using AbstractFactory.Enums;
using AbstractFactory.Model;

namespace AbstractFactory.Factory;

public class IPhone16Factory : IPhoneFactory
{
    protected override IPhone? CreateIPhone(IPhoneLevel level, CountryRulesAbstractFactory countryRules)
    {
        return level switch
        {
            IPhoneLevel.Standard => new IPhone16(countryRules),
            IPhoneLevel.HighEnd => new IPhone16ProMax(countryRules),
            _ => null
        };
    }
}