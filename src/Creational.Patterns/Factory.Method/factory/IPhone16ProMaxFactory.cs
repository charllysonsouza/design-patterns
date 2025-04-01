using FactoryMethod.Model;

namespace FactoryMethod.factory;

public class IPhone16ProMaxFactory : IPhoneFactory
{
    protected override IPhone CreateIPhone()
    {
        return new IPhone16ProMax();
    }
}