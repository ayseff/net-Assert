namespace AssertLibrary.Tests;

[TestClass]
public class IsNotEqual
{
    [TestMethod]
    public void Valid()
    {
        Assert.IsNotEqual(1, "1");
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.IsNotEqual(1, 1);
    }
}