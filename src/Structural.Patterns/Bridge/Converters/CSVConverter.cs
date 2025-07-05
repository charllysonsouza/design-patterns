using Bridge.Employees;

namespace Bridge.Converters;

public class CsvConverter : IConverter
{
    public string GetEmployeeFormated(Employee emp)
    {
        return $"{emp.Name},{emp.Age},{emp.Salary}";
    }
}