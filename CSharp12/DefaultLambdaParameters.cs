namespace CSharp12;

public class DefaultLambdaParameters
{
    public static void Method()
    {
        var IncrementBy = (int start, int increment = 1) => start + increment;

        IncrementBy(5); // 6
        IncrementBy(5, 2); // 7
    }
}