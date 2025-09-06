namespace Composite;

public interface IFileSystemItem
{
    public string Name { get; }
    public IFileSystemItem? Parent { set; }
    // Counts all characters in files content
    public int Count();
}