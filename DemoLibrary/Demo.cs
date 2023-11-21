namespace DemoLibrary;

public class Demo
{
    DemoAccess demoAccess = new DemoAccess();

    public Demo()
    {
        // Can call internal and public but not private modifier methods from DemoAccess class
        demoAccess.InternalDemo();
        demoAccess.PublicDemo();
    }
}