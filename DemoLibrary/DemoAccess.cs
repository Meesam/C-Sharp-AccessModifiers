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
}