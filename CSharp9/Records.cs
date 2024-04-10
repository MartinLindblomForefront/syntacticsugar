namespace CSharp9;

// Used for immutable data models
// Value equality (watch out for lists)
// Primary constructor (support for classes come in C#12)
// with syntax for nondestructive mutation
public record MyRecord(string FirstName, string LastName, string Title, string Description);

public class A
{
    public void Method()
    {
        var a = new MyRecord("Martin", "Lindblom", "Developer", "Lives in Linköping");
        var b = a with { FirstName = "Stefan", LastName = "Nideborn" };

        var c = a with { };

        if (a == c)
            Console.WriteLine(true);
    }
}