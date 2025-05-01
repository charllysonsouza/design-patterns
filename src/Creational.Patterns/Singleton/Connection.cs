namespace Singleton;

public class Connection
{
    public bool IsInUse { get; set; } = false;

    public void ExecuteQuery(string query)
    {
        Console.WriteLine($"Executing query: {query}");
    }
}