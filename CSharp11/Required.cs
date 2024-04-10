namespace CSharp11;

public record Required
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }

    public static Required Create(string firstName, string lastName)
    {
        return new Required() { FirstName = firstName, LastName = lastName };
    }
}