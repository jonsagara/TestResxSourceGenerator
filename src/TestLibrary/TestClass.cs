namespace TestLibrary;

public class TestClass
{
    // Does not compile: The type or namespace name 'SR' does not exist in the namespace 'TestLibrary' (are you missing an assembly reference?)
    public static string GetWelcomeMesssage()
        => TestLibrary.SR.Welcome;
}
