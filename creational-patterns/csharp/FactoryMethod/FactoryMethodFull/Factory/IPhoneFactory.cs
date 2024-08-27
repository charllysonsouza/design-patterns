using FactoryMethodFull.model;

namespace FactoryMethodFull.Factory;

public abstract class IPhoneFactory
{
    public IPhone OrderIphone()
    {
        var device = CreateIphone();
        
        device.GetHardware();
        device.Assemble();
        device.Certificates();
        device.Pack();

        return device;
    }

    protected abstract IPhone CreateIphone();
}