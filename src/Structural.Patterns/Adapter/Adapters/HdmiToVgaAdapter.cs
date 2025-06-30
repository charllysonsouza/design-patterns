using Adapter.Interfaces;

namespace Adapter.Adapters;

public class HdmiToVgaAdapter : IHdmi
{
    private IVga _vga;

    public HdmiToVgaAdapter(IVga vga)
    {
        Console.WriteLine("Connecting the HDMI to VGA using adapter...");
        this._vga = vga;
    }
    
    public void SetImage(string image)
    {
        Console.WriteLine("Converting the image from HDMI to VGA...");
        _vga.SetImage(image);
    }

    public void SetSound(string sound)
    {
       Console.WriteLine("Sorry, we don't support sound");
    }
}