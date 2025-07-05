using System.Text.Json;
using Bridge.Employees;

namespace Bridge.Converters;

public class JsonConverter : IConverter
{
    public string GetEmployeeFormated(Employee emp)
    {
        return
            $$"""
            {
                "name": "{{emp.Name}}",
                "age": {{emp.Age}},
                "salary": {{emp.Salary}}
            }
            """;
    }
}