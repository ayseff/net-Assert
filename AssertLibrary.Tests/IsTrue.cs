namespace AssertLibrary.Tests;

[TestClass]
public class IsTrue
{
    [TestMethod]
    public void Valid()
    {
        Assert.IsTrue(true);
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.IsTrue(false);
    }
}