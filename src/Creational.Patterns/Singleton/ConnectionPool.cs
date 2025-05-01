namespace Singleton;

public class ConnectionPool
{
    private static ConnectionPool? _instance;
    private const int PoolSize = 2;
    private readonly List<Connection> _connections = [];

    private ConnectionPool()
    {
        for (var i = 0; i < PoolSize; i++)
            _connections.Add(new Connection());
    }

    public static ConnectionPool GetInstance()
    {
        if (_instance == null)
            _instance = new ConnectionPool();
        
        Console.WriteLine("No connections available.");
        
        return _instance;
    }

    public Connection? GetConnection()
    {
        return _connections.FirstOrDefault(connection => !connection.IsInUse);
    }

    public void LeaveConnection(Connection connection)
    {
        connection.IsInUse = false;
    }
}