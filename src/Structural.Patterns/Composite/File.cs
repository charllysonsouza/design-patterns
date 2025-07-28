namespace Composite;

public class File(string name, string content) : IFileSystemItem
{
    public string Name { get; } = name;
    private string Content { get; } = content;

    public int Count()
    {
        return Content.Length;
    }

    public override string ToString()
    {
        return $"{Name}: {Count()}\n";
    }
}