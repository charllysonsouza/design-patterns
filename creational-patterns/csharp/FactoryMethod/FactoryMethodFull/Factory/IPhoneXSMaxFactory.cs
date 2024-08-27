using FactoryMethodFull.model;

namespace FactoryMethodFull.Factory;

public class IPhoneXSMaxFactory : IPhoneFactory
{
    protected override IPhone CreateIphone()
    {
        return new IPhoneXSMax();
    }
}