namespace AbstractFactory.Pack;

public class UsaPack : IPacking
{
    public void Pack()
    {
        Console.WriteLine("Packing according to USA rules.");
    }
}