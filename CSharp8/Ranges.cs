namespace CSharp8;

public class Ranges
{
    public void A()
    {
        int[] oneThroughTen = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        var a = oneThroughTen[..]; // 1-10
        var b = oneThroughTen[..3]; // 1-3
        var c = oneThroughTen[2..]; // 3-10
        var d = oneThroughTen[3..5]; // 4-5
        var e = oneThroughTen[^2..]; // 9-10
        var f = oneThroughTen[..^3]; // 1-7
        var g = oneThroughTen[3..^4]; // 4-6
        var h = oneThroughTen[^4..^2]; // 7-8 
    }
}