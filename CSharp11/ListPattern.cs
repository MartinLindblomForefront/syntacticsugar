namespace CSharp11;

public class ListPattern
{
    public void Method()
    {
        int[] numbers = new int[] { 1, 2, 3 };

        Console.WriteLine(numbers is [1, 2, 3]);  // True
        Console.WriteLine(numbers is [1, 2, 4]);  // False
        Console.WriteLine(numbers is [1, 2, 3, 4]);  // False
        Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]);  // True


        if (numbers is [var first, _, _])
        {
            Console.WriteLine($"The first element of a three-item list is {first}.");
        }

        Console.WriteLine(new[] { 1, 2, 3, 4, 5 } is [> 0, > 0, ..]);  // True
        Console.WriteLine(new[] { 1, 1 } is [_, _, ..]);  // True
        Console.WriteLine(new[] { 0, 1, 2, 3, 4 } is [> 0, > 0, ..]);  // False
        Console.WriteLine(new[] { 1 } is [1, 2, ..]);  // False

        Console.WriteLine(new[] { 1, 2, 3, 4 } is [.., > 0, > 0]);  // True
        Console.WriteLine(new[] { 2, 4 } is [.., > 0, 2, 4]);  // False
        Console.WriteLine(new[] { 2, 4 } is [.., 2, 4]);  // True

        Console.WriteLine(new[] { 1, 2, 3, 4 } is [>= 0, .., 2 or 4]);  // True
        Console.WriteLine(new[] { 1, 0, 0, 1 } is [1, 0, .., 0, 1]);  // True
        Console.WriteLine(new[] { 1, 0, 1 } is [1, 0, .., 0, 1]);  // False
    }
}