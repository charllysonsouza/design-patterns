using FactoryMethod.Model;

namespace FactoryMethod.factory;

public abstract class IPhoneFactory
{
    public IPhone OrderIPhone()
    {
        var device = CreateIPhone();
        
        device.GetHardware();
        device.Assemble();
        device.Certificates();
        device.Pack();
        
        return device;
    }

    protected abstract IPhone CreateIPhone();
}   