// See https://aka.ms/new-console-template for more information

using FactoryMethodFull.Factory;

public class Client
{
    public static void Main(string[] args)
    {
        IPhoneFactory iphoneXFactory = new IPhoneXFactory();
        IPhoneFactory iphoneXSMaxFactory = new IPhoneXSMaxFactory();
        IPhoneFactory iphone11Factory = new IPhone11Factory();
        IPhoneFactory iphone11ProFactory = new IPhone11ProFactory();
       
        
        Console.WriteLine("********** Ordering an Iphone X *************");
        var iphoneX = iphoneXFactory.OrderIphone();
        Console.WriteLine(iphoneX + "\n");
        
        Console.WriteLine("********** Ordering an Iphone XS Max *************");
        var iphoneXSMax = iphoneXSMaxFactory.OrderIphone();
        Console.WriteLine(iphoneXSMax + "\n");
        
        Console.WriteLine("********** Ordering an Iphone 11 *************");
        var iphone11 = iphone11Factory.OrderIphone();
        Console.WriteLine(iphone11 + "\n");
        
        Console.WriteLine("********** Ordering an Iphone 11 Pro *************");
        var iphone11Pro = iphone11ProFactory.OrderIphone();
        Console.WriteLine(iphone11Pro + "\n");
    }
}