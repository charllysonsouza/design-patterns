using Adapter.Interfaces;

namespace Adapter.Devices;

public class OldMonitor : IVga
{
    public void SetImage(string image) => Console.WriteLine(">>>> This is your video: " + image);
}