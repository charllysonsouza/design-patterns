using FactoryMethodFull.model;

namespace FactoryMethodFull.Factory;

public class IPhoneXFactory : IPhoneFactory
{
    protected override IPhone CreateIphone()
    {
        return new IPhoneX();
    }
}