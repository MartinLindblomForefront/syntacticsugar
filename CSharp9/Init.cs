namespace CSharp9;

public record Init
{
    public string Name { get; private init; }

    public Init(string name)
    {
        Name = name;
    }

    public void SetName(string newName)
    {
        Name = newName;
    }
}