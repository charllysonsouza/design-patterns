using FactoryMethod.Model;

namespace FactoryMethod.factory;

public class IPhone15Factory : IPhoneFactory
{
    protected override IPhone CreateIPhone()
    {
        return new IPhone15();
    }
}