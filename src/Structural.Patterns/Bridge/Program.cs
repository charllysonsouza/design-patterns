// See https://aka.ms/new-console-template for more information

using Bridge.Converters;
using Bridge.Employees;

IConverter csvConverter =  new CsvConverter();
IConverter jsonConverter = new JsonConverter();

Employee itGuy = new ItGuy("Maurice Moss", 32, 4444.00);
Employee projectManager =  new ProjectManager("Jen Bary", 40, 8565.45);

Console.WriteLine(csvConverter.GetEmployeeFormated(itGuy));
Console.WriteLine(csvConverter.GetEmployeeFormated(projectManager));
Console.WriteLine(jsonConverter.GetEmployeeFormated(itGuy));
Console.WriteLine(jsonConverter.GetEmployeeFormated(projectManager));