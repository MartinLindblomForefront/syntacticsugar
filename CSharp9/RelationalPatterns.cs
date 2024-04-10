namespace CSharp9;

public class RelationalPatterns
{
    public static string Classify(double length) =>
    length switch
    {
        < -4.0 => "Too short",
        > 10.0 => "Too long",
        double.NaN => "???",
        _ => "Acceptable"
    };

    public static string InRange(int value)
    {
        if (value is > 0 and < 10)
            return "Great";

        if (value is >= 10)
            return "Excellent";

        if (value is 2 or (>= 5 and <= 9))
            return "Special value";

        return "Nooo";
    }

    public static string LogicalPattern(int? value)
    {
        if (value is not null and >= 0)
            return "Ok";

        return "Nooo";
    }
}