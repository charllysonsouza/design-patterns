namespace Bridge.Employees;

public abstract class Employee(string name, int age, double salary)
{
    public string Name { get; } = name;
    public int Age { get; } = age;
    public double Salary { get; } = salary;
}