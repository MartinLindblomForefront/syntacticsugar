namespace CSharp8;

public class Using
{
    public void A()
    {
        using (var reader = new StreamReader(File.OpenRead("list.txt")))
        {
            // Logic
        }
    }

    public void B()
    {
        using var reader = new StreamReader(File.OpenRead("list.txt"));

        // Do logic
    }
}