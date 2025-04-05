using AbstractFactory.Enums;
using AbstractFactory.Model;

namespace AbstractFactory.Factory;

public abstract class IPhoneFactory
{
    public IPhone? OrderIphone(IPhoneLevel level)
    {
        var device = CreateIPhone(level);

        if (device == null) return device;
        
        device.Assemble();
        device.GetHardware();
        device.Certificates();
        device.Pack();

        return device;
    }
    
    protected abstract IPhone? CreateIPhone(IPhoneLevel level);
}