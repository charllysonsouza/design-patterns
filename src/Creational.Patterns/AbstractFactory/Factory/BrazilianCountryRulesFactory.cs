using AbstractFactory.Certificate;
using AbstractFactory.Pack;

namespace AbstractFactory.Factory;

public class BrazilianCountryRulesFactory : CountryRulesAbstractFactory
{
    public override IPacking GetPacking()
    {
        return new BrazilianPack();
    }

    public override ICertificate GetCertificates()
    {
        return new BrazilianCertificate();
    }
}