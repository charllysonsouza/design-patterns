namespace Composite;

public class Directory(string name) : IFileSystemItem
{
    public string Name { get; } = name;
    private List<IFileSystemItem> Children { get; } = [];
    private Directory? Parent { get; set; }

    public void AddItem(IFileSystemItem item)
    {
        Children.Add(item);
        if (item is Directory directory)
            directory.Parent = this;
    }

    private int GetDirectorySize(int soma)
    {
        var subtotal = 0;
        foreach (var child in Children)
        {
            switch (child)
            {
                case Directory directory:
                    subtotal += directory.GetDirectorySize(soma);
                    break;
                case File file:
                    subtotal += file.GetSize();
                    break;
            }
        }
        
        return soma +  subtotal;
    }

    public override string ToString()
    {
        return $"{Name}: {GetSize()} characters";
    }

    public int GetSize()
    {
       return GetDirectorySize(0);
    }

    public IFileSystemItem ChangeDirectory(string name)
    {
        foreach (var child in Children)
        {
            if (child.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && child is Directory)
                return child;
        }

        return this;
    }
}