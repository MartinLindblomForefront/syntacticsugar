namespace CSharp12;

public class CollectionExpressions
{
    public void Method()
    {
        int[] a = [1, 2, 3];
        List<string> b = ["one", "two", "three"];

        int[] row0 = [1, 2, 3];
        int[] row1 = [4, 5, 6];
        int[] row2 = [7, 8, 9];
        int[] single = [.. row0, .. row1, .. row2]; // 1, 2, 3, 4, 5, 6, 7, 8, 9
    }
}