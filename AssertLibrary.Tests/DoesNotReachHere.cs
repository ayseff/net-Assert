namespace AssertLibrary.Tests;

[TestClass]
public class DoesNotReachHere
{
    [TestMethod, ExpectedException(typeof(ShouldNotReachHereException))]
    public void Throw()
    {
        Assert.DoesNotReachHere();
    }
}