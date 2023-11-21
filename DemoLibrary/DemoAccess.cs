namespace DemoLibrary;

public class DemoAccess
{
    // Can call only with in the class
    private void PrivateDemo()
    {
        Console.WriteLine("This is Private Modifier Demo");
    }

    // Can call only with in the Assembly or Project 
    internal void InternalDemo()
    {
        Console.WriteLine("This is Internal Modifier Demo");
    }

    // Can call from anywhere whoever reference this class and within the same Project
    public void PublicDemo()
    {
        Console.WriteLine("This is Public Modifier Demo");
    }

    // Can call only with in the class or from the class which is inherit from this class
    protected void ProtectedDemo()
    {
        Console.WriteLine("This is Protected Modifier Demo");
    }

    // Can call from within the same assembly or Project and from class which is in different assembly or project that is inherit from the base class 
    protected internal void ProtectedInternalDemo()
    {
        Console.WriteLine("This is Protected internal Modifier Demo");
    }
}