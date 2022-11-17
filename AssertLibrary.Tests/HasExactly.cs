namespace AssertLibrary.Tests;

[TestClass]
public class HasExactly
{
    [TestMethod]
    public void Valid()
    {
        Assert.HasExactly(3, new[] { 1, 2, 3, });
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.HasExactly(3, new[] { 1, 2, });
    }
}