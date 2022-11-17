namespace AssertLibrary.Tests;

[TestClass]
public class UseException
{
    [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext context)
    {
        Assert.UseException();
    }
}