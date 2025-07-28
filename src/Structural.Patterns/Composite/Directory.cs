namespace Composite;

public class Directory(string name) : IFileSystemItem
{
    public string Name { get; } = name;
    private List<IFileSystemItem> Children { get; } = [];
   

    public void AddItem(IFileSystemItem item)
    {
        Children.Add(item);
    }

    public override string ToString()
    {
        return $"{Name}: {Count()} characters";
    }
    
    public int Count()
    {
        var total = 0;
        foreach (var child in Children)
            total += child.Count();
        
        return total;
    }
}