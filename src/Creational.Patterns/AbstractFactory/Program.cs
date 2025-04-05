using AbstractFactory.Enums;
using AbstractFactory.Factory;

CountryRulesAbstractFactory brazilianCountryRules = new BrazilianCountryRulesFactory();
CountryRulesAbstractFactory usaCountryRules = new UsaCountryRulesFactory();

IPhoneFactory iphone15Factory = new IPhone15Factory();
IPhoneFactory iphone16Factory = new IPhone16Factory();

Console.WriteLine("#### Ordering an Iphone 15 HighEnd with brazilian country rules ####");
var iphone15HighEnd = iphone15Factory.OrderIphone(IPhoneLevel.HighEnd, brazilianCountryRules);
Console.WriteLine("##################################### \n\n");

Console.WriteLine("#### Ordering an Iphone 15 Standard with USA country rules ####");
var iphone15Standard = iphone15Factory.OrderIphone(IPhoneLevel.Standard, usaCountryRules);
Console.WriteLine("##################################### \n\n");

Console.WriteLine("#### Ordering an Iphone 16 HighEnd with brazilian country rules ####");
var iphone16HighEnd = iphone16Factory.OrderIphone(IPhoneLevel.HighEnd, brazilianCountryRules);
Console.WriteLine("##################################### \n\n");

Console.WriteLine("#### Ordering an Iphone 16 Standard with USA country rules ####");
var iphone16Standard = iphone16Factory.OrderIphone(IPhoneLevel.Standard, usaCountryRules);

