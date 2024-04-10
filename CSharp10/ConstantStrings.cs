namespace CSharp10;

public class ConstantStrings
{
    public const string FirstName = "Martin";
    public const string LastName = "Lindblom";
    public const string UserName = "marli733";

    public const string FullName = $"{FirstName}, {LastName} - ({UserName})"; // "Martin, Lindblom - (marli733)"    
}