namespace CSharp8;

public class PatternMatching
{
    private string? a;

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public string TranslateDirection(Direction direction)
    {
        return direction switch
        {
            Direction.Up => "Up",
            Direction.Down => "Down",
            Direction.Left => "Left",
            Direction.Right => "Right",
            _ => throw new NotImplementedException()
        };
    }

    public static bool IsChristmas(DateTime date) // Only for illustration!! Use a library ;)
        => date is { Year: 2024, Month: 12, Day: 24 };



    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }

    public static void PositionalPattern()
    {
        var a = new Point(1, 2);
        var s = a switch
        {
            Point(0, 0) => "origin",
            Point(1, 2) => "Home",
            Point(int x, int y) => $"{x}, {y}",
            _ => "???"
        };

        Console.WriteLine(s);
    }



    public static bool TuplePattern(int a, int b, int c)
    {
        return (a, b, c) switch
        {
            (1, 2, 3) => true,
            (0, 0, 0) => false,
            (9, 9, 9) => true,
            _ => false
        };
    }
}