namespace CSharp8;

public interface IInterfaceWithDefaultMembers
{
    public const string Name = "MyInterfaceName";



    public int OperatorValue { get; }
    public static int operator +(IInterfaceWithDefaultMembers current, int other) => current.OperatorValue + other;
    // CS0567 C# Interfaces cannot contain conversion, equality, or inequality operators



    public static string A { get; }
    static IInterfaceWithDefaultMembers()
    { // Must be parameterless
        A = "Hello World!";
        AutoProperty = "AAAAAAAAAAA";
    }



    public class MyNestedClass
    {
        public string Data = "Oooo";
    }



    private static string _field = "Mine";
    public static string Property
    {
        get
        {
            return _field;
        }
        set
        {
            _field = value;
        }
    }
    public static string AutoProperty { get; set; }
    public string GetValue() => "Returning this string";
    private readonly static string[] _collection = new string[100];
    public string this[int i]
    {
        get { return _collection[i]; }
        set { _collection[i] = value; }
    }



    public event EventHandler OnChange;



    public string Pub { get; }
    protected string Prot { get; }
    internal string Int { get; }
    private static string Priv => "OK"; // Must have a body since nothing can implement it, static also makes sense for the same reason



    void Print() => Console.WriteLine("Original");
}

public interface IPrintOverride : IInterfaceWithDefaultMembers
{
    void IInterfaceWithDefaultMembers.Print() => Console.WriteLine("From IPrintOverride instead");
}

public class A : IInterfaceWithDefaultMembers
{
    // A.Print => "Original"
}

public class B : IPrintOverride
{
    // B.Print => "From IPrintOverride instead"
}

public interface IReAbstraction : IInterfaceWithDefaultMembers
{
    abstract void IInterfaceWithDefaultMembers.Print();
}

public class C : IReAbstraction
{
    public void Print() => Console.WriteLine("Must implement this");
}