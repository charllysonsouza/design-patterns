using Adapter.Interfaces;

namespace Adapter.Devices;

public class Tv : IHdmi
{
    public void SetImage(string image) => Console.WriteLine(">>>> This is your video: " + image);

    public void SetSound(string sound) => Console.WriteLine(">>>> This is your sound: " + sound);
}