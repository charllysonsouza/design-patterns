using AbstractFactory.Certificate;
using AbstractFactory.Pack;

namespace AbstractFactory.Factory;

public abstract class CountryRulesAbstractFactory
{
    public abstract IPacking GetPacking();
    public abstract ICertificate GetCertificates();
}