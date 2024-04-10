namespace CSharp8;

// See nullable context
public class Nullable
{
    public Mine mustNotBeNull;
    public Mine? canBeNull;

    public void AssingIfNull(Mine newValue)
    {
        canBeNull ??= newValue;
    }
}

public class Mine;