using Directory = Composite.Directory;
using File = Composite.File;

var a1 = new File("APX1_POO_Q1.txt", "Considere ...");
var a2 = new File("APX1_POO_Q2.txt", "Suponha que ...");

var d1 = new Directory("APs");
d1.AddItem(a1);
d1.AddItem(a2);

var a3 = new File("AD1_FAC.txt", "Demonstre ...");
var a4 = new File("AD2_FAC.txt", "Implemente ...");

var d2 = new Directory("ADs");
d2.AddItem(a3);
d2.AddItem(a4);

var d3 = new Directory("Avaliacoes");
d3.AddItem(d1);
d3.AddItem(d2);

Console.WriteLine(d3);
Console.WriteLine(d2);
Console.WriteLine(d1);



