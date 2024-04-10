namespace CSharp10;

public record PropertyPatterns(Point Start, Point End, int I = 0)
{
    public static bool IsAtAnyEnd(PropertyPatterns p)
        => p is { Start.X: 0 } or { End.Y: 0 };
}

public record Point(int X, int Y);