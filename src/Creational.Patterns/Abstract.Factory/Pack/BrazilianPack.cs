namespace AbstractFactory.Pack;

public class BrazilianPack : IPacking
{
    public void Pack()
    {
        Console.WriteLine("Packing according to Brazilian rules.");
    }
}