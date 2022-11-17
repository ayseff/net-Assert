namespace AssertLibrary.Tests;

[TestClass]
public class HasMore
{
    [TestMethod]
    public void Valid()
    {
        Assert.HasMore(3, new[] { 1, 2, 3, 4, });
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.HasMore(3, new[] { 1, 2, 3, });
    }
}