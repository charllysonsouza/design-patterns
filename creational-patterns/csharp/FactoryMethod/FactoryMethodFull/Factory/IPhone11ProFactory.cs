using FactoryMethodFull.model;

namespace FactoryMethodFull.Factory;

public class IPhone11ProFactory : IPhoneFactory
{
    protected override IPhone CreateIphone()
    {
        return new IPhone11Pro();
    }
}