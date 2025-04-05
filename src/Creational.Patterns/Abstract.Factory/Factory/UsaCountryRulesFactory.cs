using AbstractFactory.Certificate;
using AbstractFactory.Pack;

namespace AbstractFactory.Factory;

public class UsaCountryRulesFactory : CountryRulesAbstractFactory
{
    public override IPacking GetPacking()
    {
        return new UsaPack();
    }

    public override ICertificate GetCertificates()
    {
        return new UsaCertificate();
    }
}