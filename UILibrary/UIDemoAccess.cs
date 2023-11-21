using DemoLibrary;

namespace UILibrary;

public class UIDemoAccess
{
     DemoAccess demoAccess = new DemoAccess();

     public void UiDemo()
     {
          // Only can call public methods from DemoAccess class
          demoAccess.PublicDemo();
     }
}