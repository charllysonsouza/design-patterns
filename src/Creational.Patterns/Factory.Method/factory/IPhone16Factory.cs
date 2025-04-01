using FactoryMethod.Model;

namespace FactoryMethod.factory;

public class IPhone16Factory : IPhoneFactory
{
    protected override IPhone CreateIPhone()
    {
        return new IPhone16();
    }
}