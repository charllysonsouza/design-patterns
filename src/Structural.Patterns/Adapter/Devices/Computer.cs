using Adapter.Interfaces;

namespace Adapter.Devices;

public class Computer
{
    private IHdmi? _port;

    public void Connect(IHdmi screen)
    {
        Console.WriteLine("Connection on HDMI port...");
        _port = screen;
    }

    public void SendImageAndSound(string image, string sound)
    {
        if (_port == null)
        {
            Console.WriteLine("Connect a HDMI cable first");
            return;
        }
        
        _port.SetImage(image);
        _port.SetSound(sound);
    }
}