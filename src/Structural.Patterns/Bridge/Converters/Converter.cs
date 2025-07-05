using Bridge.Employees;

namespace Bridge.Converters;

public interface IConverter
{
   public string GetEmployeeFormated(Employee emp);
}