namespace Composite;

public interface IFileSystemItem
{
    public string Name { get; }
    public int GetSize();
}