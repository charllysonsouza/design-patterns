using AbstractFactory.Enums;
using AbstractFactory.Model;

namespace AbstractFactory.Factory;

public class IPhone15Factory : IPhoneFactory
{
    protected override IPhone? CreateIPhone(IPhoneLevel level, CountryRulesAbstractFactory countryRules)
    {
        return level switch
        {
            IPhoneLevel.Standard=> new IPhone15(countryRules),
            IPhoneLevel.HighEnd => new IPhone15Pro(countryRules),
            _ => null
        };
    }
}