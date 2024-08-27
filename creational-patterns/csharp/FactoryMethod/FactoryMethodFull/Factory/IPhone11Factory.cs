using FactoryMethodFull.model;

namespace FactoryMethodFull.Factory;

public class IPhone11Factory : IPhoneFactory
{
    protected override IPhone CreateIphone()
    {
        return new IPhone11();
    }
}