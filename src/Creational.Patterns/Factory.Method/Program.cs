using FactoryMethod.factory;
using FactoryMethod.Model;

IPhoneFactory iphone16ProMaxFactory = new IPhone16ProMaxFactory();
IPhoneFactory iphone16Factory = new IPhone16Factory();
IPhoneFactory iphone15Factory = new IPhone15Factory();


Console.WriteLine("### Ordering an Iphone 16 Pro Max");
var iPhone1 = iphone16ProMaxFactory.OrderIPhone();
Console.WriteLine($"IPhone type: {iPhone1}");

Console.WriteLine("\n\n### Ordering an Iphone 16");
var iPhone2 = iphone16Factory.OrderIPhone();
Console.WriteLine($"IPhone type: {iPhone2}");

Console.WriteLine("\n\n### Ordering an Iphone 15");
var iPhone3 = iphone15Factory.OrderIPhone();
Console.WriteLine($"IPhone type: {iPhone3}");

