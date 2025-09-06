namespace Composite;

public class Directory(string name) : IFileSystemItem
{
    public string Name { get; } = name;
    public IFileSystemItem? Parent { get; set; }
    private List<IFileSystemItem> Children { get; } = [];
   

    public void AddItem(IFileSystemItem item)
    {
        Children.Add(item);
        item.Parent = this;
    }

    public override string ToString()
    {
        var text = $"{Name}: {Count()}\n";
        foreach (var child in Children)
                text += child.ToString();
        
        return text;
    }
    
    public int Count()
    {
        var total = 0;
        foreach (var child in Children)
            total += child.Count();
        
        return total;
    }
}