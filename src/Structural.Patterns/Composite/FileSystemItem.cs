namespace Composite;

public interface IFileSystemItem
{
    public string Name { get; }
    // Counts all characters in files content
    public int Count();
}